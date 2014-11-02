using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    public enum EBarType
    {
        UNKNOWN,
        LONG,
        MEDIUM,
        SHORT,
        MOLD
    }

    class Bar : IInputable
    {
        public readonly int SPEED = (int)(8 * Main.RunningSpeedFactor);

        private double EnlargementFactor;
        private Image[] gh;
        private DisplayInfo dInfo;
        private IOperator Operator;
        private EBarType mBar;
        private EBarType moldBar; //for swap
        private int AcceleratingCount;
        public int CenterX { get; set; }
        public int CenterY { get; set; }
        private int Width { get; set; }
        public int EnlargedWidth { get { return (int)(Width * EnlargementFactor); } }
        public int Height { get; set; }
        public int Top { get { return CenterY - Height / 2; } }
        public int Bottom { get { return CenterY + Height / 2; } }
        public int Left { get { return CenterX - EnlargedWidth / 2; } }
        public int Right { get { return CenterX + EnlargedWidth / 2; } }
        public bool IsDead { get; set; }
        public bool IsMove { get; set; } // 動いたかどうか

        /// <summary>
        /// 加速 -なら左，+なら右
        /// </summary>
        public int Accel { get; set; }

        public Bar(EBarType BarType, DisplayInfo dInfo, IOperator Operator)
        {
            this.dInfo = dInfo;
            this.Operator = Operator;

            mBar = moldBar = BarType;
            gh = new Image[4];
            gh[0] = new Bitmap(Main.ResourceDirectory + "bar.bmp");
            gh[1] = new Bitmap(Main.ResourceDirectory + "barsecond.bmp");
            gh[2] = new Bitmap(Main.ResourceDirectory + "barthird.bmp");
            gh[3] = new Bitmap(Main.ResourceDirectory + "barcatcher.bmp");

            Bitmap bi = gh[0] as Bitmap;

            if (mBar == EBarType.SHORT)
            {
                Width = (int)bi.Width / 2;
                SPEED = 16;
            }
            else
                Width = (int)bi.Width;
            Height = (int)bi.Height;
    
            CenterX = dInfo.Width / 2;
            CenterY = 540;
            Reset();
            IsDead = false;
            IsMove = false;
        }

        public ProcessResult Process(Input input, Graphics g, UserChoice uc, TakeOver takeOver)
        {
            if (!IsDead)
            {
                //キー処理
                if (!KeyGet(input))
                {
                    Accel = 0;
                    AcceleratingCount = 0;
                }
            }

            //描画処理
            Draw(g);

            return new ProcessResult() { IsDead = IsDead };
        }

        private void Draw(Graphics g)
        {
            g.DrawImage(gh[(int)mBar - 1], CenterX - EnlargedWidth / 2, CenterY - Height / 2,
                EnlargedWidth, Height);
            DrawUtil.Debug_DrawBlockRectangle(g, CenterX - EnlargedWidth / 2, CenterY - Height / 2,
                EnlargedWidth, Height);
        }

        private bool KeyGet(Input input)
        {
            bool IsPushedAnyKey = Operator.MoveBar(this, ref AcceleratingCount, input);

            if (CenterX < EnlargedWidth / 2)
                CenterX = EnlargedWidth / 2;

            if (CenterX > dInfo.Width - EnlargedWidth / 2)
                CenterX = dInfo.Width - EnlargedWidth / 2;

            return IsPushedAnyKey;
        }

        private bool _IsBallCatch;
        public bool IsBallCatch
        {
            get { return _IsBallCatch; }
            set
            {
                if (value && mBar != EBarType.MOLD)
                {
                    moldBar = mBar;
                    mBar = EBarType.MOLD;
                }
                else if (!value)
                    mBar = moldBar;

                _IsBallCatch = value;
            }
        }

        internal void Reset()
        {
            EnlargementFactor = 1;
        }

        internal void ExtendWidth()
        {
            EnlargementFactor += 0.5;
        }
    }
}
