using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WPFBlockCrash
{
    class Bar
    {
        private const int SPEED = 8;

        private int EnlargementFactor;
        private ImageSource[] gh;
        private DisplayInfo dInfo;
        private int mBar;

        public Bar(int barnum, DisplayInfo dInfo)
        {
            this.dInfo = dInfo;
            mBar = barnum - 1;

            gh = new ImageSource[3];
            gh[0] = new BitmapImage(new Uri(Main.ResourceDirectory, "bar.bmp"));
            gh[1] = new BitmapImage(new Uri(Main.ResourceDirectory, "barsecond.bmp"));
            gh[2] = new BitmapImage(new Uri(Main.ResourceDirectory, "barthird.bmp"));

            BitmapImage bi = gh[0] as BitmapImage;

            Width = (int)bi.PixelWidth;
            Height = (int)bi.PixelHeight;

            X = dInfo.Width / 2;
            Y = 540;
            EnlargementFactor = 2;
            IsDead = false;
        }

        internal bool Process(Input input, DrawingContext dc)
        {
            if (!IsDead)
            {
                //キー処理
                if (!KeyGet(input))
                    Accel = 0;
            }

            //描画処理
            Draw(dc);

            return IsDead;
        }

        private void Draw(DrawingContext dc)
        {
            DrawUtil.DrawExtendGraph(dc, X - Width * EnlargementFactor / 4, Y - Height / 2,
                X + Width * EnlargementFactor / 4, Y + Height / 2, gh[mBar]);
        }

        private bool KeyGet(Input input)
        {
            bool IsPushedAnyKey = false;

            if (input.barx != 0) //怪しい…
            {
                X = input.barx;
                IsPushedAnyKey = true;
            }

            if (input.key256[Input.KEY_INPUT_LEFT] == 1)
            {
                X -= SPEED;
                Accel = -1;
                IsPushedAnyKey = true;
            }
            else if (input.key256[Input.KEY_INPUT_RIGHT] == 1)
            {
                X += SPEED;
                Accel = 1;
                IsPushedAnyKey = true;
            }
            else if (input.key256[Input.KEY_INPUT_ESCAPE] == 1)
            {
                IsDead = true;
            }

            if (X < Width * EnlargementFactor / 4)
                X = Width * EnlargementFactor / 4;

            if (X > dInfo.Width - Width * EnlargementFactor / 4)
                X = dInfo.Width - Width * EnlargementFactor / 4;

            MX = X;
            return IsPushedAnyKey;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int MX { get; set; }
        public bool IsDead { get; set; }

        /// <summary>
        /// 加速 -なら左，+なら右
        /// </summary>
        public int Accel { get; set; }

        internal void Reset()
        {
            EnlargementFactor = 2;
        }

        internal void ExtendWidth()
        {
            ++EnlargementFactor;
        }
    }
}
