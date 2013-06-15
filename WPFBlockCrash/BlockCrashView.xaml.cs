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
        private DispatcherTimer timerToRun;
        private DispatcherTimer timerToRender;
        private WriteableBitmap bitmap;
        private RenderTargetBitmap bs;

        public BlockCrashView()
        {
            InitializeComponent();

            input = new Input();
            //input.AT = true;
            main = new Main(new DisplayInfo() { Width = 800, Height = 600 });

        }

        private RenderTargetBitmap CreateBitmap(int width, int height, double dpi, Action<DrawingContext> render)
        {
            GC.Collect();
            RenderTargetBitmap bitmap = null;
            DrawingVisual drawingVisual = new DrawingVisual();
            using (DrawingContext drawingContext = drawingVisual.RenderOpen())
            {
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
            timerToRender.Tick += timerToRender_Tick;
            timerToRender.Interval = TimeSpan.FromMilliseconds(1);
            timerToRender.Start();

            timerToRun = new DispatcherTimer();
            timerToRun.Tick += timerToRun_Tick;
            timerToRun.Interval = TimeSpan.FromMilliseconds(1);
            timerToRun.Start();
        }

        private object render_object = new object();

        private void timerToRender_Tick(object sender, EventArgs e)
        {
            if (bs == null)
                return;

            WriteableBitmap wb = null;

            lock (render_object)
            {
                wb = new WriteableBitmap(bs);
            }

            SetBitmapToImage(image, wb);
        }

        private void timerToRun_Tick(object sender, EventArgs e)
        {
            main.ATMode(input);
            RenderTargetBitmap rtb = null;
            rtb = CreateBitmap(800, 600, 96, dc => main.ProcessLoop(input, dc));

            lock (render_object)
            {
                bs = rtb;
            }
        }


        public void KeyDownRButton()
        {
            input.RB.KeyDown();
            input.key256[Input.KEY_INPUT_RIGHT] = (char)1;
            input.IsPushedKeys = true;
        }

        public void KeyDownLButton()
        {
            input.LB.KeyDown();
            input.key256[Input.KEY_INPUT_LEFT] = (char)1;
            input.IsPushedKeys = true;
        }

        public void MoveBarTo(int vx)
        {
            input.barx = vx;
        }

        public void KeyDownEnterButton()
        {
            input.EB.KeyDown();
            input.key256[Input.KEY_INPUT_RETURN] = (char)1;
            input.IsPushedKeys = true;
        }

        public void KeyDownSpaceButton()
        {
            input.key256[Input.KEY_INPUT_SPACE] = (char)1;
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

        public void ExitGame()
        {
            timerToRender.Stop();
            timerToRun.Stop();
        }

        private Thread th;
        private Main main;
        private Input input;

        public void KeyUpSpaceButton()
        {
            input.key256[Input.KEY_INPUT_SPACE] = (char)0;
        }

        public void KeyUpLButton()
        {
            input.LB.KeyUp();
            input.key256[Input.KEY_INPUT_LEFT] = (char)0;
        }

        public void KeyUpRButton()
        {
            input.RB.KeyUp();
            input.key256[Input.KEY_INPUT_RIGHT] = (char)0;
        }

        public void KeyUpEnterButton()
        {
            input.EB.KeyUp();
            input.key256[Input.KEY_INPUT_RETURN] = (char)0;
        }
    }
}
