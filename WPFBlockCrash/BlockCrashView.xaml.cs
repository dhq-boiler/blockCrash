using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WPFBlockCrash
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class BlockCrashView : UserControl
    {
        //private BackgroundWorker worker;
        private DispatcherTimer timerToRun;
        private DispatcherTimer timerToRender;
        private RenderTargetBitmap bitmap;

        public BlockCrashView()
        {
            InitializeComponent();

            //worker = new BackgroundWorker();
            //worker.DoWork += new DoWorkEventHandler(DoWork);
            //worker.WorkerSupportsCancellation = true;



            input = new Input();
            //input.AT = true;
            main = new Main(new DisplayInfo() { Width = 800, Height = 600 });

        }

        private RenderTargetBitmap CreateBitmap(int width, int height, double dpi, Action<DrawingContext> render)
        {
            DrawingVisual drawingVisual = new DrawingVisual();
            using (DrawingContext drawingContext = drawingVisual.RenderOpen())
            {
                //main.ProcessLoop(input, drawingContext);
                render(drawingContext);
            }

            if (bitmap == null)
                bitmap = new RenderTargetBitmap(width, height, dpi, dpi, PixelFormats.Default);
            bitmap.Render(drawingVisual);

            return bitmap;
        }

        private void SetBitmapToImage(System.Windows.Controls.Image Image, WriteableBitmap bitmap)
        {
            if (!Image.CheckAccess())
                Dispatcher.Invoke(new Action(() => SetBitmapToImage(Image, bitmap)));
            else
                Image.Source = bitmap;
        }

        public void RunGame()
        {
            timerToRender = new DispatcherTimer();

            timerToRun = new DispatcherTimer();
            timerToRun.Tick += timerToRun_Tick;
            timerToRun.Interval = TimeSpan.FromMilliseconds(1);
            timerToRun.Start();
        }

        private void timerToRun_Tick(object sender, EventArgs e)
        {
            main.ATMode(input);
            RenderTargetBitmap bs = CreateBitmap(800, 600, 96, dc => main.ProcessLoop(input, dc));
            WriteableBitmap wb = new WriteableBitmap(bs);
            SetBitmapToImage(image, wb);
        }

        //public void BeginGame()
        //{
        //    worker.RunWorkerAsync();
        //}

        //private void DoWork(object sender, DoWorkEventArgs e)
        //{
        //    while (!worker.CancellationPending)
        //    {
        //        Dispatcher.Invoke(new Action(() => main.ProcessLoop(input, dg)));
        //    }
        //}

        public void PushRButton()
        {
            input.RB = true;
            input.IsPushedKeys = true;
        }

        public void PushLButton()
        {
            input.LB = true;
            input.IsPushedKeys = true;
        }

        public void MoveBarTo(int vx)
        {
            input.barx = vx;
        }

        public void PushEnterButton()
        {
            input.EB = true;
            input.IsPushedKeys = true;
        }

        public bool IsAuto
        {
            get { return input.AT; }
            set { input.AT = value; }
        }

        public void KeyEnd()
        {
            input.IsPushedKeys = false;
        }

        //public void Finish()
        //{
        //    worker.CancelAsync();
        //    //input.IsFinished = true;
        //}

        private Thread th;
        private Main main;
        private Input input;
    }
}
