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
        private int moldBar;
        private int accelcount;

        public Bar(int barnum, DisplayInfo dInfo)
        {
            this.dInfo = dInfo;
            mBar = moldBar = barnum - 1;

            gh = new ImageSource[4];
            gh[0] = new BitmapImage(new Uri(Main.ResourceDirectory, "bar.bmp"));
            gh[1] = new BitmapImage(new Uri(Main.ResourceDirectory, "barsecond.bmp"));
            gh[2] = new BitmapImage(new Uri(Main.ResourceDirectory, "barthird.bmp"));
            gh[3] = new BitmapImage(new Uri(Main.ResourceDirectory, "barcatcher.bmp"));

            BitmapImage bi = gh[0] as BitmapImage;

            if (mBar == 2) // 2ならバーは小さくする
                Width = (int)bi.PixelWidth/2;
            else
                Width = (int)bi.PixelWidth;
            Height = (int)bi.PixelHeight;
    
            X = dInfo.Width / 2;
            Y = 540;
            EnlargementFactor = 2;
            IsDead = false;
            IsMove = false;
        }

        internal bool Process(Input input, DrawingContext dc)
        {
            if (!IsDead)
            {
                //キー処理
                if (!KeyGet(input))
                {
                    Accel = 0;
                    accelcount = 0;
                }
            }

            //描画処理
            Draw(dc);

            return IsDead;
        }

        private void Draw(DrawingContext dc)
        {
            //if (mBar == 2){ // 2ならバーは小さくする
            //    DrawUtil.DrawExtendGraph(dc, X - Width * EnlargementFactor / 8, Y - Height / 2,
            //    X + Width * EnlargementFactor / 8, Y + Height / 2, gh[mBar]);
            //}
            //else
            //{
                DrawUtil.DrawExtendGraph(dc, X - Width * EnlargementFactor / 4, Y - Height / 2,
                X + Width * EnlargementFactor / 4, Y + Height / 2, gh[mBar]);
            //}
        }

        private bool KeyGet(Input input)
        {
            bool IsPushedAnyKey = false;

            if (!input.AT && input.barx != 0) 
            {
                IsMove = true;
                X = input.barx;
                IsPushedAnyKey = true;
            }

            if (input.key256[Input.KEY_INPUT_LEFT] == 1)
            {
                IsMove = true;
                X -= SPEED;
                ++accelcount;

                if (accelcount < 25)
                    Accel = -1;
                else if (accelcount < 50)
                    Accel = -2;
                else
                    Accel = -3;

                IsPushedAnyKey = true;
            }
            else if (input.key256[Input.KEY_INPUT_RIGHT] == 1)
            {
                IsMove = true;
                X += SPEED;
                ++accelcount;

                if (accelcount < 25)
                    Accel = 1;
                else if (accelcount < 50)
                    Accel = 2;
                else
                    Accel = 3;
                
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
        public bool IsMove { get; set; } // 動いたかどうか

        /// <summary>
        /// 加速 -なら左，+なら右
        /// </summary>
        public int Accel { get; set; }

        public void BallCatch( bool on ){ // ボールがバーにくっつく状態
            if (on && mBar != 3)
            {
                moldBar = mBar;
                mBar = 3;
                   
            }
            else if(!on)
                mBar = moldBar;
        }

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
