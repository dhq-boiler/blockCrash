using OpenCvItmdUtil;
using OpenCvSharp;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

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

        #endregion

        public MainWindow()
        {
            InitializeComponent();

            capture = new CvCapture(0);
            bitmap = new WriteableBitmap(VGACameraWidth, VGACameraHeight, 92, 92, PixelFormats.Bgr24, null);
            calibrator = new Calibrator(new CvSize((int)ImageWidthStandard, (int)ImageHeightStandard), new CvSize(10, 7));

            //ChangeWindowSize.Visibility = System.Windows.Visibility.Visible;
            MaximizeWindowSize.Visibility = System.Windows.Visibility.Visible;
            NomalizeWindowSize.Visibility = System.Windows.Visibility.Hidden;
            StartCalibration.Visibility = System.Windows.Visibility.Visible;

            ScrollBar.Thumb.ProjectionColor = Colors.Lime;
            ScrollBar.Thumb.JudgementColor = Colors.Magenta;
            ScrollBar.Thumb.PushedButtonBorderColor = Colors.Black;
            ScrollBar.Thumb.PushedButtonBorderThickness = 2;
            ScrollBar.Thumb.ThresholdCheckPercent = 5;
            ScrollBar.Thumb.ShadowThresholdPercent = 1;
            ScrollBar.Thumb.ThresholdDifferentPixel = 70;
            ScrollBar.Thumb.ThresholdUnderAsShadow1ch = 20;
            ScrollBar.Thumb.MarginLeft =
                ScrollBar.Thumb.MarginRight =
                ScrollBar.Thumb.MarginTop =
                ScrollBar.Thumb.MarginBottom = 10;
            ScrollBar.Thumb.IsEnableLongTouch = false;
            ScrollBar.ScrollAreaColor = Colors.LightBlue;
            ScrollBar.PixelsPerStep = 1;

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

                    ////コントロールの切り替え
                    ViewCameraInputGrid.Visibility = System.Windows.Visibility.Hidden;
                    //ProcessTouchButtonGrid.Visibility = System.Windows.Visibility.Visible;
                    ProcessGrid.Visibility = Visibility.Visible;

                    ////タッチボタンの初期化
                    //PrepareButton();

                    ScrollBar.PrepareScrollbar(mainGrid, PreviewImage);

                    ////ShadowPixelIndicator.FontSize = 30;
                    //infoIndicator.Content = "TouchButton's Background has been obtained.";

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
                            if (ScrollBar.SetThumbReferenceImageIfThatIsNull(imgMat, SecondToWaitForAppearingTouchButton))
                            {
                                StageRetrieveingScrollArea = 1;
                                ScrollBar.Thumb.Visibility = System.Windows.Visibility.Hidden;
                                ScrollBar.PaintScrollAreaBy(ScrollBar.Thumb.ProjectionColor);
                            }
                            break;
                        case 1:
                            if (ScrollBar.SetButtonColorBackgroundIfThatIsNull(imgMat, SecondToWaitForAppearingTouchButton))
                            {
                                StageRetrieveingScrollArea = 2;
                                ScrollBar.PaintScrollAreaBy(ScrollBar.ScrollAreaColor);
                            }
                            break;
                        case 2:
                            if (ScrollBar.SetScrollAreaBackgroundIfThatIsNull(imgMat, SecondToWaitForAppearingTouchButton))
                            {
                                timerToRetrieveBackground.Stop();

                                ScrollBar.Thumb.Visibility = System.Windows.Visibility.Visible;
                                ScrollBar.Thumb.ButtonTouching += new libts.WPFTouchButton.ButtonTouchingEventHandler((s, ea) => ScrollBar.ScrollProcess(s, ea));
                                ScrollBar.ValueChanged += new EventHandler((s, ea) => Move());

                                int ThumbValidPixels = ScrollBar.Thumb.ValidateArea.Width * ScrollBar.Thumb.ValidateArea.Height;

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

            using (frame = Cv.QueryFrame(capture))
            using (CvMat imgCap = new CvMat(480, 640, MatrixType.U8C3))
            using (CvMat imgMat = new CvMat(480, 640, MatrixType.U8C3))
            {
                DateTime now = DateTime.Now;
                frame.Copy(imgCap);

                ProjectionTransform.transform(imgMat, imgCap, vtArray);

                ScrollBar.Thumb.Process(imgMat, SlideChangeTime, now);

                imgMat.DrawRect(ScrollBar.Thumb.ButtonPosition, new CvScalar(0, 0, 255));
                Cv.ShowImage("Screen", imgMat);

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
            //blockCrashView.MoveBarTo((int)((barXValue + 50d) / range));
            double a = barXValue / barXMaxValue; //0.0 -> 1.0
            double b = a * 700; //0.0 -> 700.0
            double c = b + 50; // 50.0 -> 750.0
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
