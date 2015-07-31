using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using libts;
using libts.ctrlctr;
using libts.data;
using OpenCvSharp;
using OpenCvSharp.CPlusPlus;
using WPFBlockCrash;

namespace ScrollCrash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        #region カメラ入力系

        private VideoCapture vc;
        private WriteableBitmap bitmap;
        private const int VGACameraWidth = 640;
        private const int VGACameraHeight = 480;

        #endregion

        #region DispatcherTimer

        private DispatcherTimer timerToPreview; //起動時カメラプレビュー
        private DispatcherTimer timerToCalibrate; //キャリブレーション
        private DispatcherTimer timerToRetrieveBackground; //背景画像取得
        private DispatcherTimer timerToProcess;

        #endregion

        #region キャリブレーション用変数

        private Calibrator calibrator;

        /// <summary>
        /// 検出されたチェスボードの4頂点
        /// </summary>
        private Point2f[] vtArray;

        /// <summary>
        /// キャリブレーション試行回数
        /// </summary>
        private int calibratingCount;

        /// <summary>
        /// キャリブレーション最大試行回数
        /// </summary>
        private readonly int Max_calibratingCount = 5;

        #endregion

        #region UI系

        public double ImageWidthStandard { get { return mainGrid.ActualWidth; } }
        public double ImageHeightStandard { get { return mainGrid.ActualHeight; } }
        private int StageRetrieveingScrollArea;
        private readonly int SecondToWaitForAppearingTouchButton = 1;
        public bool IsMaximized { get; set; }
        private int CameraNumber;

        #endregion

        #region XMLデータ

        private readonly string data_enter_xml = ".\\..\\..\\xml\\data_enter.xml";
        private readonly string data_thumb_xml = ".\\..\\..\\xml\\data_thumb.xml";
        private readonly string settings_xml = ".\\..\\..\\xml\\settings.xml";

        #endregion

        private Input input;

        #region Auto Mode Display

        private DateTime ChangedDisplayInfomationTime;
        private readonly TimeSpan InformationDisplayInterval = TimeSpan.FromSeconds(1);
        
        #endregion

        public MainWindow()
        {
            InitializeComponent();

            bitmap = new WriteableBitmap(VGACameraWidth, VGACameraHeight, 92, 92, PixelFormats.Bgr24, null);
            calibrator = new Calibrator(new OpenCvSharp.CPlusPlus.Size((int)ImageWidthStandard, (int)ImageHeightStandard), new OpenCvSharp.CPlusPlus.Size(10, 7));
        }

        private void PreviewCameraInputLoop(object s, EventArgs e)
        {
            using (Mat mat = new Mat())
            {
                vc.Retrieve(mat, CameraChannels.Zero);
                TSUtil.CopyImageToBitmap(bitmap, mat);
            }
            SetBitmapToImage(PreviewImage, bitmap);
        }

        private void SetBitmapToImage(System.Windows.Controls.Image PreviewImage, WriteableBitmap bitmap)
        {
            if (!PreviewImage.CheckAccess())
                Dispatcher.Invoke(() => SetBitmapToImage(PreviewImage, bitmap));
            else
                PreviewImage.Source = bitmap;
        }

        private void StartCalibration_Click(object sender, RoutedEventArgs e)
        {
            //カメラプレビューの停止
            timerToPreview.Stop();

            //コントロールの切り替え
            InitializeGrid.Visibility = System.Windows.Visibility.Hidden;

            //チェスボード投影
            if (!IsMaximized)
                bitmap = new WriteableBitmap((int)ImageWidthStandard, (int)ImageHeightStandard, 92, 92, PixelFormats.Gray8, null);
            else
                bitmap = new WriteableBitmap((int)mainGrid.ActualWidth, (int)mainGrid.ActualHeight, 92, 92, PixelFormats.Gray8, null);
            TSUtil.CopyImageToBitmap(bitmap, calibrator.ChessBoardMat);
            SetBitmapToImage(PreviewImage, bitmap);

            //キャリブレーションテストの初期化
            calibratingCount = 0;

            //キャリブレーションの実行
            timerToCalibrate = new DispatcherTimer();
            timerToCalibrate.Tick += (s, ea) => CalibrateCameraInputLoop(s, ea);
            timerToCalibrate.Interval = TimeSpan.FromMilliseconds(1);
            timerToCalibrate.Start();
        }
        
        private void CalibrateCameraInputLoop(object s, EventArgs ea)
        {
            Trace.WriteLine("Trying Calibration Count:" + (calibratingCount + 1));

            using (Mat mat = new Mat())
            {
                vc.Retrieve(mat, CameraChannels.Zero);
                vtArray = calibrator.Detect10x7(mat);
                if (vtArray != null)
                {
                    Trace.WriteLine("Calibration succeeded!");

                    //キャリブレーションの停止
                    timerToCalibrate.Stop();

                    //コントロールの切り替え
                    ViewCameraInputGrid.Visibility = System.Windows.Visibility.Hidden;
                    ProcessGrid.Visibility = Visibility.Visible;

                    //タッチボタン・スクロールバーの初期化
                    EnterButton.Prepare(mainGrid, PreviewImage);
                    ScrollBar.PrepareScrollbar(mainGrid, PreviewImage);

                    timerToRetrieveBackground = new DispatcherTimer();
                    timerToRetrieveBackground.Tick += (ss, e) => RetrieveButtonBackground(ss, e);
                    timerToRetrieveBackground.Interval = TimeSpan.FromMilliseconds(1);
                    timerToRetrieveBackground.Start();

                }
                else if ((++calibratingCount + 1) > Max_calibratingCount)
                {
                    Trace.WriteLine("Failed Calibration...");

                    //キャリブレーションの停止
                    timerToCalibrate.Stop();

                    //コントロールの切り替え
                    InitializeGrid.Visibility = System.Windows.Visibility.Visible;

                    //カメラプレビューの再開
                    bitmap = new WriteableBitmap(VGACameraWidth, VGACameraHeight, 92, 92, PixelFormats.Bgr24, null);
                    timerToPreview.Start();
                }
            }
        }

        private void RetrieveButtonBackground(object ss, EventArgs e)
        {
            using (Mat imgMat = new Mat())
            using (Mat imgCap = new Mat())
            {
                vc.Retrieve(imgCap, CameraChannels.Zero);
                ProjectionTransform.Transform(imgMat, imgCap, vtArray);

                try
                {
                    switch (StageRetrieveingScrollArea)
                    {
                        case 0:
                            if (EnterButton.SetReferenceImageIfThatIsNull(imgMat, SecondToWaitForAppearingTouchButton))
                            {
                                StageRetrieveingScrollArea = 1;
                                ScrollBar.Thumb.Visibility = System.Windows.Visibility.Hidden;
                                ScrollBar.PaintScrollAreaBy(ScrollBar.Thumb.ProjectionColor);
                                ScrollBar.Thumb.ReferenceImageAdjustedTime = DateTime.Now;
                            }
                            break;
                        case 1:
                            if (ScrollBar.SetThumbReferenceImageIfThatIsNull(imgMat, SecondToWaitForAppearingTouchButton))
                            {
                                StageRetrieveingScrollArea = 2;
                                ScrollBar.SetSinceChangingScrollAreaColorNow();
                            }
                            break;
                        case 2:
                            if (ScrollBar.SetButtonColorBackgroundIfThatIsNull(imgMat, SecondToWaitForAppearingTouchButton))
                            {
                                StageRetrieveingScrollArea = 3;
                                ScrollBar.PaintScrollAreaBy(ScrollBar.ScrollAreaColor);
                                ScrollBar.SetSinceChangingScrollAreaColorNow();
                            }
                            break;
                        case 3:
                            if (ScrollBar.SetScrollAreaBackgroundIfThatIsNull(imgMat, SecondToWaitForAppearingTouchButton))
                            {
                                timerToRetrieveBackground.Stop();

                                ScrollBar.Thumb.Visibility = System.Windows.Visibility.Visible;
                                ScrollBar.Thumb.ButtonTouching += (s, ea) => ScrollBar.ScrollProcess(s, ea);
                                ScrollBar.ValueChanged += (s, ea) => Move();

                                EnterButton.ButtonHandDown += (s, ea) => blockCrashView.KeyDownEnterButton();
                                EnterButton.ButtonHandUp += (s, ea) => blockCrashView.KeyUpEnterButton();

                                int ThumbValidPixels = ScrollBar.Thumb.ValidateArea.Width * ScrollBar.Thumb.ValidateArea.Height;

                                blockCrashView.Initialize(WPFBlockCrash.BlockCrashView.EOperatingType.VIRTOS_SLIDER);
                                blockCrashView.IsAuto = false;
                                blockCrashView.RunGame();

                                timerToProcess = new DispatcherTimer();
                                timerToProcess.Tick += (s, ea) => ProcessingLoop(s, ea);
                                timerToProcess.Interval = TimeSpan.FromMilliseconds(1);
                                timerToProcess.Start();
                            }
                            break;
                    }

                }
                catch (Exception)
                {
                    //！？
                    throw;
                }
            }
        }

        private void ProcessingLoop(object s, EventArgs ea)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            using (Mat imgCap= new Mat())
            using (Mat imgMat = new Mat())
            {
                DateTime now = DateTime.Now;
                vc.Retrieve(imgCap, CameraChannels.Zero);
                ProjectionTransform.Transform(imgMat, imgCap, vtArray);

                EnterButton.Process(imgMat, now);
                ScrollBar.Thumb.Process(imgMat, now);

                DebugImShow(imgCap, imgMat);

                if (input.AT && (DateTime.Now - ChangedDisplayInfomationTime) >= InformationDisplayInterval)
                {
                    switch (StatusInfoIndicator.Visibility)
                    {
                        case System.Windows.Visibility.Visible:
                            StatusInfoIndicator.Visibility = System.Windows.Visibility.Hidden;
                            break;
                        case System.Windows.Visibility.Hidden:
                            StatusInfoIndicator.Visibility = System.Windows.Visibility.Visible;
                            break;
                    }

                    ChangedDisplayInfomationTime = DateTime.Now;
                }
                else if (input.AT)
                { }
                else
                {
                    StatusInfoIndicator.Visibility = System.Windows.Visibility.Hidden;
                }

                sw.Stop();
            }

            int key = Cv.WaitKey(1);
            if (key == 0x1b)
            {
                Close();
            }
        }

        [Conditional("DEBUG")]
        private void DebugImShow(Mat imgCap, Mat imgMat)
        {
            Cv2.ImShow("Camera Input", imgCap);
            Cv2.ImShow("EnterButton Current Image", TSUtil.ExtractROI(imgMat, EnterButton.ButtonPosition));
            Cv2.ImShow("ScrollBarhandle Current Image", TSUtil.ExtractROI(imgMat, ScrollBar.Thumb.ButtonPosition));
            Cv2.ImShow("EnterButton Reference Image", EnterButton.ReferenceImage);
            Cv2.ImShow("ScrollBarHandle Reference Image", ScrollBar.Thumb.ReferenceImage);
            imgMat.Line(new CvPoint((int)(ScrollBar.ScrollAreaRectangle.Left + ScrollBar.center_of_gravity), (int)ScrollBar.ScrollAreaRectangle.Top),
                new CvPoint((int)(ScrollBar.ScrollAreaRectangle.Left + ScrollBar.center_of_gravity), (int)ScrollBar.ScrollAreaRectangle.Bottom),
                new CvScalar(255, 0, 0), 3);
            imgMat.Rectangle(ScrollBar.Thumb.ButtonPosition, new CvScalar(0, 0, 255));
            imgMat.Rectangle(EnterButton.ButtonPosition, new CvScalar(0, 0, 255));
            Cv2.ImShow("Camera Input that is projective transformation", imgMat);
        }

        private void Move()
        {
            // 25 <= vx <= 775 のスケールに変換する
            int barXValue = (int)ScrollBar.Value;
            int barXMaxValue = ScrollBar.MaxValue;
            double a = (double)barXValue / (double)barXMaxValue; //0.0 -> 1.0
            double b = a * 750; //0.0 -> 750.0
            double c = b + 25; // 25.0 -> 775.0
            blockCrashView.MoveBarTo((int)c);
        }

        private void MaximizeWindowSize_Click(object sender, RoutedEventArgs e)
        {
            IsMaximized = true;

            MaximizeWindowSize.Visibility = System.Windows.Visibility.Hidden;
            NomalizeWindowSize.Visibility = System.Windows.Visibility.Visible;

            mainWindow.SizeToContent = System.Windows.SizeToContent.Manual;
            mainWindow.WindowState = System.Windows.WindowState.Normal;
            mainWindow.WindowStyle = System.Windows.WindowStyle.None;
            mainWindow.WindowState = System.Windows.WindowState.Maximized;
        }

        private void NomalizeWindowSize_Click(object sender, RoutedEventArgs e)
        {
            IsMaximized = false;

            MaximizeWindowSize.Visibility = System.Windows.Visibility.Visible;
            NomalizeWindowSize.Visibility = System.Windows.Visibility.Hidden;

            mainWindow.SizeToContent = SizeToContent.WidthAndHeight;
            mainWindow.WindowState = WindowState.Normal;
            mainWindow.WindowStyle = WindowStyle.SingleBorderWindow;

            this.PreviewImage.Width = ImageWidthStandard;
            this.PreviewImage.Height = ImageHeightStandard;
        }

        private void mainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (IsMaximized)
            {
                this.PreviewImage.Width = mainGrid.ActualWidth;
                this.PreviewImage.Height = mainGrid.ActualHeight;
                calibrator = new Calibrator(new OpenCvSharp.CPlusPlus.Size((int)mainGrid.ActualWidth, (int)mainGrid.ActualHeight), new OpenCvSharp.CPlusPlus.Size(10, 7));
            }
            else
            {
                this.PreviewImage.Width = ImageWidthStandard;
                this.PreviewImage.Height = ImageHeightStandard;
                calibrator = new Calibrator(new OpenCvSharp.CPlusPlus.Size((int)mainGrid.ActualWidth, (int)mainGrid.ActualHeight), new OpenCvSharp.CPlusPlus.Size(10, 7));
            }
        }

        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCameraNumber();

            OpenVideoCapture();

            MaximizeWindowSize.Visibility = System.Windows.Visibility.Visible;
            NomalizeWindowSize.Visibility = System.Windows.Visibility.Hidden;
            StartCalibration.Visibility = System.Windows.Visibility.Visible;

            this.EnterButton.ControlName = "EnterButton";
            EnterButton.ProjectionColor = Colors.Lime;
            EnterButton.JudgementColor = Colors.Magenta;
            EnterButton.PushedButtonBorderColor = Colors.Black;
            EnterButton.PushedButtonBorderThickness = 2;
            EnterButton.ThresholdCheckPercent = 30;
            EnterButton.ThresholdDifferentPixel = 100;
            EnterButton.ThresholdUnderAsShadow1ch = 25;
            EnterButton.MarginLeft = EnterButton.MarginTop = EnterButton.MarginRight = EnterButton.MarginBottom = 10;
            EnterButton.IsEnableLongTouch = false;
            EnterButton.JudgingTimeOut = TimeSpan.FromSeconds(1);
            // 五十嵐 1行追加
            EnterButton.ThresholdSD = 10;

            this.ScrollBar.ControlName = "Slider";
            this.ScrollBar.Thumb.ControlName = "Thumb";
            ScrollBar.Thumb.ProjectionColor = Colors.Lime;
            ScrollBar.Thumb.JudgementColor = Colors.Magenta;
            ScrollBar.Thumb.PushedButtonBorderColor = Colors.Black;
            ScrollBar.Thumb.PushedButtonBorderThickness = 2;
            ScrollBar.Thumb.ThresholdCheckPercent = 30;
            ScrollBar.Thumb.ThresholdDifferentPixel = 100;
            ScrollBar.Thumb.ThresholdUnderAsShadow1ch = 25;
            ScrollBar.Thumb.MarginLeft =
                ScrollBar.Thumb.MarginRight =
                ScrollBar.Thumb.MarginTop =
                ScrollBar.Thumb.MarginBottom = 10;
            ScrollBar.Thumb.IsEnableLongTouch = false;
            ScrollBar.Thumb.JudgingTimeOut = TimeSpan.FromSeconds(1);
            ScrollBar.ScrollAreaColor = Colors.LightBlue;
            ScrollBar.PixelsPerStep = 1;
            // 五十嵐 1行追加
            ScrollBar.Thumb.ThresholdSD = 10;

            ControlCenter dialog = new ControlCenter();
            dialog.ControlCenterVM.Add(this.EnterButton);
            dialog.ControlCenterVM.Add(this.ScrollBar.Thumb);
            dialog.ControlCenterVM.Add(this.ScrollBar);
            dialog.Show();

            LoadParameters(data_enter_xml, EnterButton);
            LoadParameters(data_thumb_xml, ScrollBar.Thumb);

            input = new Input();
            blockCrashView.input = input;
            StatusInfoIndicator.Content = "Auto Mode";

            timerToPreview = new DispatcherTimer();
            timerToPreview.Interval = TimeSpan.FromMilliseconds(1);
            timerToPreview.Tick += (s, ea) => PreviewCameraInputLoop(s, ea);
            timerToPreview.Start();
        }

        private static void LoadParameters(string filename, WPFTouchButton2 touchButton)
        {
            try
            {
                WPFTouchButtonData data = WPFTouchButtonData.Deserialize(filename);
                touchButton.ThresholdCheck = data.ThresholdCheck;
                touchButton.ThresholdTouch = data.ThresholdTouch;
                touchButton.ThresholdDifferentPixel = data.ThresholdDifferentPixel;
                touchButton.ThresholdUnderAsShadow1ch = data.ThresholdUnderAsShadow1ch;
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "タッチボタン設定読み込み失敗", MessageBoxButton.OK);
            }
        }

        private void OpenVideoCapture()
        {
            try
            {
                vc = new VideoCapture(CameraNumber);
            }
            catch (OpenCvSharpException)
            {
                MessageBox.Show(string.Format("カメラが応答しません．{0} の <UseCameraNumber> を確認してください．UseCameraNumber={1}", settings_xml, CameraNumber), "エラー");
                Environment.Exit(1);
            }
        }

        private void LoadCameraNumber()
        {
            try
            {
                CameraNumber = Settings.Load(settings_xml).UseCameraNumber;
            }
            catch (IOException)
            {
                try
                {
                    Settings.Save(settings_xml, new Settings());
                    MessageBox.Show(string.Format("{0} を出力しました．<UseCameraNumber>に0から始まるカメラ番号を入力して再実行してください．", settings_xml));
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "IOエラー", MessageBoxButton.OK);
                }
                Environment.Exit(1);
            }
        }

        private static void SaveParameters(string filename, WPFTouchButton2 touchButton)
        {
            try
            {
                WPFTouchButtonData data = new WPFTouchButtonData();
                data.ThresholdCheck = touchButton.ThresholdCheck;
                data.ThresholdTouch = touchButton.ThresholdTouch;
                data.ThresholdDifferentPixel = touchButton.ThresholdDifferentPixel;
                data.ThresholdUnderAsShadow1ch = touchButton.ThresholdUnderAsShadow1ch;
                data.Serialize(filename);
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "タッチボタン設定書き込み失敗", MessageBoxButton.OK);
            }
        }

        private void mainWindow_Closed(object sender, EventArgs e)
        {
            SaveParameters(data_enter_xml, EnterButton);
            SaveParameters(data_thumb_xml, ScrollBar.Thumb);
        }
    }
}
