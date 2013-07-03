﻿using System;
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

        private int EnlargementFactor;
        private Image[] gh;
        private DisplayInfo dInfo;
        private IOperator Operator;
        private EBarType mBar;
        private EBarType moldBar; //for swap
        private int AcceleratingCount;
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
            {// 2ならバーは小さくする
                Width = (int)bi.Width / 2;
                SPEED = 16;
            }
            else
                Width = (int)bi.Width;
            Height = (int)bi.Height;
    
            X = dInfo.Width / 2;
            Y = 540;
            EnlargementFactor = 2;
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
            g.DrawImage(gh[(int)mBar - 1], X - Width * EnlargementFactor / 4, Y - Height / 2,
                Width * EnlargementFactor / 2, Height);
        }

        private bool KeyGet(Input input)
        {
            bool IsPushedAnyKey = Operator.MoveBar(this, ref AcceleratingCount, input);

            if (X < Width * EnlargementFactor / 4)
                X = Width * EnlargementFactor / 4;

            if (X > dInfo.Width - Width * EnlargementFactor / 4)
                X = dInfo.Width - Width * EnlargementFactor / 4;

            MX = X;

            return IsPushedAnyKey;
        }

        public void BallCatch( bool on )// ボールがバーにくっつく状態
        { 
            if (on && mBar != EBarType.MOLD)
            {
                moldBar = mBar;
                mBar = EBarType.MOLD;
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
