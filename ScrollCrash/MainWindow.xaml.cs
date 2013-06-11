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
                    //ViewCameraInputGrid.Visibility = System.Windows.Visibility.Hidden;
                    //ProcessTouchButtonGrid.Visibility = System.Windows.Visibility.Visible;

                    ////タッチボタンの初期化
                    //PrepareButton();

                    ////ShadowPixelIndicator.FontSize = 30;
                    //infoIndicator.Content = "TouchButton's Background has been obtained.";

                    //timerToRetrieveBackground = new DispatcherTimer();
                    //timerToRetrieveBackground.Tick += (ss, e) => RetrieveButtonBackground(ss, e);
                    //timerToRetrieveBackground.Interval = TimeSpan.FromMilliseconds(1);
                    //timerToRetrieveBackground.Start();
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
