﻿using System;
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
        private DispatcherTimer timerToRun;
        //private RenderTargetBitmap bitmap;
        private WriteableBitmap bitmap;

        public BlockCrashView()
        {
            InitializeComponent();

            bitmap = new WriteableBitmap(800, 600, 92, 92, PixelFormats.Bgr24, null);

            input = new Input();
            main = new Main(new DisplayInfo() { Width = 800, Height = 600 });
        }

        private WriteableBitmap CreateBitmap(int width, int height, double dpi, Action<Graphics> render)
        {
            bitmap.Lock();
            var bmp = new Bitmap(bitmap.PixelWidth, bitmap.PixelHeight, bitmap.BackBufferStride, System.Drawing.Imaging.PixelFormat.Format24bppRgb, bitmap.BackBuffer);

            Graphics g = Graphics.FromImage(bmp);

            render(g);

            g.Dispose();
            bmp.Dispose();

            bitmap.AddDirtyRect(new Int32Rect(0, 0, 800, 600));
            bitmap.Unlock();

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
            timerToRun = new DispatcherTimer();
            timerToRun.Tick += timerToRun_Tick;
            timerToRun.Interval = TimeSpan.FromMilliseconds(1);
            timerToRun.Start();
        }

        private void timerToRun_Tick(object sender, EventArgs e)
        {
            main.ATMode(input);
            SetBitmapToImage(image, CreateBitmap(800, 600, 96, g => main.ProcessLoop(input, g)));
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

        private Thread th;
        private Main main;
        public Input input { get; set; }

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
