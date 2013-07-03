using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
        public enum EOperatingType
        {
            DESKTOP_KEYBOARD,
            VIRTOS_SLIDER,
            AUTO
        }

        private Main main;
        public Input input;
        private DispatcherTimer timerToRun;
        private WriteableBitmap bitmap;
        private const int DisplayWidth = 800;
        private const int DisplayHeight = 600;

        public bool IsInitialized { get; set; }

        public BlockCrashView()
        {
            InitializeComponent();

            bitmap = new WriteableBitmap(DisplayWidth, DisplayHeight, 92, 92, PixelFormats.Bgr24, null);

            input = new Input();
        }

        public void Initialize(EOperatingType OperatingType)
        {
            main = new Main(new DisplayInfo() { Width = DisplayWidth, Height = DisplayHeight }, OperatingType);
            IsInitialized = true;
        }

        private WriteableBitmap RenderBitmap(Action<Graphics> Run_Main_ProcessLoop)
        {
            try
            {
                bitmap.Lock();
                using (var bmp = new Bitmap(bitmap.PixelWidth, bitmap.PixelHeight, bitmap.BackBufferStride, System.Drawing.Imaging.PixelFormat.Format24bppRgb, bitmap.BackBuffer))
                {
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        Run_Main_ProcessLoop(g);
                    }
                }
                bitmap.AddDirtyRect(new Int32Rect(0, 0, DisplayWidth, DisplayHeight));
            }
            finally
            {
                bitmap.Unlock();
            }
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
            if (!IsInitialized)
                throw new InvalidOperationException("Not Initialize yet.");

            timerToRun = new DispatcherTimer();
            timerToRun.Tick += timerToRun_Tick;
            timerToRun.Interval = TimeSpan.FromMilliseconds(1000d / 60);
            timerToRun.Start();
        }

        private void timerToRun_Tick(object sender, EventArgs e)
        {
            main.ATMode(input);
            SetBitmapToImage(image, RenderBitmap(g => main.ProcessLoop(input, g)));
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
            timerToRun.Stop();
        }

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
