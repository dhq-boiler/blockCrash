using OpenCvItmdUtil;
using OpenCvSharp;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using WPFBlockCrash;

namespace ScrollCrash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region カメラ入力系

        private IplImage frame;
        private CvCapture capture;
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
        private ValueType[] vtArray;

        /// <summary>
        /// キャリブレーション試行回数
        /// </summary>
        private int calibratingCount;

        /// <summary>
        /// キャリブレーション最大試行回数
        /// </summary>
        private const int Max_calibratingCount = 5;
        private DateTime SlideChangeTime;

        #endregion

        #region UI系

        public const double ImageWidthStandard = 1280;
        public const double ImageHeightStandard = 800;
        private int StageRetrieveingScrollArea;
        private const int SecondToWaitForAppearingTouchButton = 1;

        public bool IsMaximized { get; set; }
        private int CameraNumber;

        #endregion

        private Input input;

        public MainWindow()
        {
            InitializeComponent();

            try
            {
                CameraNumber = Settings.Load("settings.xml").UseCameraNumber;
            }
            catch (IOException e)
            {
                Settings.Save("settings.xml", new Settings());
                MessageBox.Show("settings.xmlを出力しました．<UseCameraNumber>に0から始まるカメラ番号を入力して再起動してください．");
                Environment.Exit(1);
            }

            capture = new CvCapture(CameraNumber);
            bitmap = new WriteableBitmap(VGACameraWidth, VGACameraHeight, 92, 92, PixelFormats.Bgr24, null);
            calibrator = new Calibrator(new CvSize((int)ImageWidthStandard, (int)ImageHeightStandard), new CvSize(10, 7));

            MaximizeWindowSize.Visibility = System.Windows.Visibility.Visible;
            NomalizeWindowSize.Visibility = System.Windows.Visibility.Hidden;
            StartCalibration.Visibility = System.Windows.Visibility.Visible;

            EnterButton.ProjectionColor = Colors.Lime;
            EnterButton.JudgementColor = Colors.Magenta;
            EnterButton.PushedButtonBorderColor = Colors.Black;
            EnterButton.PushedButtonBorderThickness = 2;
            EnterButton.ThresholdCheckPercent = 25;
            EnterButton.ShadowThresholdPercent = 1;
            EnterButton.ThresholdDifferentPixel = 100;
            EnterButton.ThresholdUnderAsShadow1ch = 20;
            EnterButton.MarginLeft = EnterButton.MarginTop = EnterButton.MarginRight = EnterButton.MarginBottom = 10;
            EnterButton.IsEnableLongTouch = false;
            EnterButton.JudgingTimeOut = TimeSpan.FromSeconds(1);

            ScrollBar.Thumb.ProjectionColor = Colors.Lime;
            ScrollBar.Thumb.JudgementColor = Colors.Magenta;
            ScrollBar.Thumb.PushedButtonBorderColor = Colors.Black;
            ScrollBar.Thumb.PushedButtonBorderThickness = 2;
            ScrollBar.Thumb.ThresholdCheckPercent = 25;
            ScrollBar.Thumb.ShadowThresholdPercent = 1;
            ScrollBar.Thumb.ThresholdDifferentPixel = 100;
            ScrollBar.Thumb.ThresholdUnderAsShadow1ch = 20;
            ScrollBar.Thumb.MarginLeft =
                ScrollBar.Thumb.MarginRight =
                ScrollBar.Thumb.MarginTop =
                ScrollBar.Thumb.MarginBottom = 10;
            ScrollBar.Thumb.IsEnableLongTouch = false;
            ScrollBar.Thumb.JudgingTimeOut = TimeSpan.FromSeconds(1);
            ScrollBar.ScrollAreaColor = Colors.LightBlue;
            ScrollBar.PixelsPerStep = 1;
            ScrollBar.RadiusOfSearchAreaCircle = Math.Sqrt(Math.Pow(ScrollBar.Thumb.ActualWidth, 2) + Math.Pow(ScrollBar.Thumb.ActualHeight, 2)) * 5;

            input = new Input();
            blockCrashView.input = input;
            StatusInfoIndicator.Content = "Auto Mode";

            timerToPreview = new DispatcherTimer();
            timerToPreview.Interval = TimeSpan.FromMilliseconds(1);
            timerToPreview.Tick += (s, e) => PreviewCameraInputLoop(s, e);
            timerToPreview.Start();
        }

        private void PreviewCameraInputLoop(object s, EventArgs e)
        {
            using (frame = Cv.QueryFrame(capture))
            {
                Util.CopyImageToBitmap(bitmap, frame);
            }
            SetBitmapToImage(PreviewImage, bitmap);
        }

        private void SetBitmapToImage(System.Windows.Controls.Image PreviewImage, WriteableBitmap bitmap)
        {
            if (!PreviewImage.CheckAccess())
                Dispatcher.Invoke(new Action(() => SetBitmapToImage(PreviewImage, bitmap)));
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
            Util.CopyImageToBitmap(bitmap, calibrator.ChessBoardMat, 1);
            SetBitmapToImage(PreviewImage, bitmap);

            //キャリブレーションテストの初期化
            calibratingCount = 0;

            //キャリブレーションの実行
            timerToCalibrate = new DispatcherTimer();
            timerToCalibrate.Tick += (s, ea) => CalibrateCameraInputLoop(s, ea);
            timerToCalibrate.Interval = TimeSpan.FromMilliseconds(1);
            timerToCalibrate.Start();
        }

        private int calibrateSuccessedCount = 0;

        private void CalibrateCameraInputLoop(object s, EventArgs ea)
        {
            Debug.WriteLine("Trying Calibration Count:" + (calibratingCount + 1));

            using (frame = Cv.QueryFrame(capture))
            using (CvMat mat = new CvMat(VGACameraHeight, VGACameraWidth, MatrixType.U8C3))
            {
                frame.Copy(mat);
                vtArray = calibrator.Detect10x7(mat);
                if (vtArray != null)
                {
                    Debug.WriteLine("Calibration succeeded!");

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
                    Debug.WriteLine("Failed Calibration...");

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
            using (frame = Cv.QueryFrame(capture))
            using (CvMat imgCap = new CvMat(480, 640, MatrixType.U8C3))
            using (CvMat imgMat = new CvMat(480, 640, MatrixType.U8C3))
            {
                frame.Copy(imgCap);

                ProjectionTransform.transform(imgMat, imgCap, vtArray);

                try
                {
                    switch (StageRetrieveingScrollArea)
                    {
                        case 0:
                            if (EnterButton.SetReferenceImageIfThatIsNull(imgMat, SecondToWaitForAppearingTouchButton))
                            {
                                StageRetrieveingScrollArea = 1;
                            }
                            break;
                        case 1:
                            if (ScrollBar.SetThumbReferenceImageIfThatIsNull(imgMat, SecondToWaitForAppearingTouchButton))
                            {
                                StageRetrieveingScrollArea = 2;
                                ScrollBar.Thumb.Visibility = System.Windows.Visibility.Hidden;
                                ScrollBar.PaintScrollAreaBy(ScrollBar.Thumb.ProjectionColor);
                            }
                            break;
                        case 2:
                            if (ScrollBar.SetButtonColorBackgroundIfThatIsNull(imgMat, SecondToWaitForAppearingTouchButton))
                            {
                                StageRetrieveingScrollArea = 3;
                                ScrollBar.PaintScrollAreaBy(ScrollBar.ScrollAreaColor);
                            }
                            break;
                        case 3:
                            if (ScrollBar.SetScrollAreaBackgroundIfThatIsNull(imgMat, SecondToWaitForAppearingTouchButton))
                            {
                                timerToRetrieveBackground.Stop();

                                ScrollBar.Thumb.Visibility = System.Windows.Visibility.Visible;
                                ScrollBar.Thumb.ButtonTouching += new libts.WPFTouchButton.ButtonTouchingEventHandler((s, ea) => ScrollBar.ScrollProcess(s, ea));
                                ScrollBar.ValueChanged += new EventHandler((s, ea) => Move());

                                EnterButton.ButtonHandDown += new EventHandler((s, ea) => blockCrashView.KeyDownEnterButton());
                                EnterButton.ButtonHandUp += new EventHandler((s, ea) => blockCrashView.KeyUpEnterButton());

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

        private DateTime ChangedDisplayInfomationTime;
        private readonly TimeSpan InformationDisplayInterval = TimeSpan.FromSeconds(1);

        private void ProcessingLoop(object s, EventArgs ea)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            using (frame = Cv.QueryFrame(capture))
            using (CvMat imgCap = new CvMat(480, 640, MatrixType.U8C3))
            using (CvMat imgMat = new CvMat(480, 640, MatrixType.U8C3))
            {
                DateTime now = DateTime.Now;
                frame.Copy(imgCap);

                ProjectionTransform.transform(imgMat, imgCap, vtArray);

                EnterButton.Process(imgMat, SlideChangeTime, now);
                ScrollBar.Thumb.Process(imgMat, SlideChangeTime, now);

#if Debug
                imgMat.DrawLine(new CvPoint((int)(ScrollBar.ScrollAreaRectangle.Left + ScrollBar.center_of_gravity), (int)ScrollBar.ScrollAreaRectangle.Top),
                    new CvPoint((int)(ScrollBar.ScrollAreaRectangle.Left + ScrollBar.center_of_gravity), (int)ScrollBar.ScrollAreaRectangle.Bottom),
                    new CvScalar(255, 0, 0), 3);
                imgMat.DrawRect(ScrollBar.Thumb.ButtonPosition, new CvScalar(0, 0, 255));
                imgMat.DrawRect(EnterButton.ButtonPosition, new CvScalar(0, 0, 255));
                Cv.ShowImage("Screen", imgMat);
#endif
                if (input.AT && (DateTime.Now - ChangedDisplayInfomationTime).TotalSeconds >= 1)
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
                {

                }
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

        private void Move()
        {
            int barXValue = (int)ScrollBar.Value;
            int barXMaxValue = ScrollBar.MaxValue;
            // 50 <= vx <= 750;
            double a = (double)barXValue / (double)barXMaxValue; //0.0 -> 1.0
            double b = a * 700; //0.0 -> 700.0
            double c = b + 50; // 50.0 -> 750.0
            //Debug.WriteLine("a:" + a + " b:" + b + " c:" + c);
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
                calibrator = new Calibrator(new CvSize((int)mainGrid.ActualWidth, (int)mainGrid.ActualHeight), new CvSize(10, 7));
            }
            else
            {
                this.PreviewImage.Width = ImageWidthStandard;
                this.PreviewImage.Height = ImageHeightStandard;
                calibrator = new Calibrator(new CvSize((int)mainGrid.ActualWidth, (int)mainGrid.ActualHeight), new CvSize(10, 7));
            }
        }
    }
}
