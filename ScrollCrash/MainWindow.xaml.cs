using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using OpenCvItmdUtil;
using OpenCvSharp;

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

        #region 背景画像取得

        private int SecondToWaitForAppearingTouchButton = 1;

        #endregion

        public MainWindow()
        {
            InitializeComponent();

            capture = new CvCapture(0);
            bitmap = new WriteableBitmap(640, 480, 92, 92, PixelFormats.Bgr24, null);
            calibrator = new Calibrator(new CvSize(640, 480), new CvSize(10, 7));

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

        private void StartCalibration_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
