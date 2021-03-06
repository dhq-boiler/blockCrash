﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WPFBlockCrash
{
    class Ball : IInputable
    {
        private Image[] gh;
        private DisplayInfo dInfo;
        public int CatchXOffset { get; set; }
        public int baccel { get; set; } 
        public int AccelVector { get; set; } // 加速の向き
        public int CenterX { get; set; }
        public int CenterY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Top { get { return CenterY - Height / 2; } }
        public int Bottom { get { return CenterY + Height / 2; } }
        public int Left { get { return CenterX - Width / 2; } }
        public int Right { get { return CenterX + Width / 2; } }
        public int DX { get; set; }
        public int DY { get; set; }
        public int Level { get; set; }
        public int OldY { get; set; }
        public bool IsDead { get; set; }
        public bool PlaySound { get; set; }
        public EPenetrability Penetrability { get; set; }

        public int PenetratingCount { get; set; }

        public bool IsSmall { get; set; }
        public int IsNewCount { get; set; }
        public bool IsStop { get; set; }
        public bool IsCaught { get; set; }
        public bool IsBounding { get; set; }

        public bool NowCrashingBlockOrGettingItem { get; set; }

        private LinkedList<Ball> OverlappingBalls;
        private Bar bar;

        public enum EPenetrability
        {
            NON_PENETRATING,
            PENETRATING
        }

        public Ball(DisplayInfo dInfo, Bar bar)
        {
            this.dInfo = dInfo;
            gh = new Image[4];
            gh[0] = new Bitmap(Main.ResourceDirectory + "ball.png");
            gh[1] = new Bitmap(Main.ResourceDirectory + "ball_pene.png");
            gh[2] = new Bitmap(Main.ResourceDirectory + "ball2.png");
            gh[3] = new Bitmap(Main.ResourceDirectory + "ball2_pene.png");

            Width = (int)gh[0].Width;
            Height = (int)gh[0].Height;

            CenterX = dInfo.Width / 2 + 30;
            CenterY = 540 - Height + 2;
            DX = 0;
            DY = 0;
            OldY = CenterY;
            IsDead = false;
            IsCaught = true;
            PlaySound = false;
            Penetrability = EPenetrability.NON_PENETRATING;
            PenetratingCount = 0;
            IsSmall = false;
            IsNewCount = 0;
            Level = 1;
            IsStop = true;
            CatchXOffset = 0;
            baccel = 0;
            AccelVector = 0;
            this.bar = bar;

            OverlappingBalls = new LinkedList<Ball>();
        }

        private void Draw(Graphics g)
        {
            Image src = null;

            if (Penetrability == EPenetrability.PENETRATING)
            {
                if (IsSmall)
                    src = gh[3];
                else
                    src = gh[1];
            }
            else if (IsSmall)
                src = gh[2];
            else
                src = gh[0];

            g.DrawImage(src, CenterX - Width / 2, CenterY - Height / 2);
            DrawUtil.Debug_DrawBlockRectangle(g, CenterX - Width / 2, CenterY - Height / 2, Width, Height);
        }

        internal void LvUp(int incLv)
        {
            if (Level < 20)
            {
                Level += incLv;

                if (DX < 0)
                    --DX;
                else
                    ++DX;

                if (DY < 0)
                    --DY;
                else
                    ++DY;
            }
        }

        internal void RamdomWalk()
        {
            if (IsSmall) return;

            int r = Main.rand.Next() % 5;
            DX += r - 6;
            DY += (10 - r) - 6;
        }

        public ProcessResult Process(Input input, Graphics g, UserChoice uc, TakeOver takeOver)
        {
            NowCrashingBlockOrGettingItem = false;

            if (!IsCaught || IsSmall)
                Move();

            UpdateOverlapping();

            //キー処理
            KeyGet(input);

            if (PenetratingCount > 0)
            {
                --PenetratingCount;
                if (PenetratingCount == 0)
                    Penetrability = EPenetrability.NON_PENETRATING;
            }
            if (IsNewCount > 0)
            {
                --IsNewCount;
            }

            Draw(g);

            return new ProcessResult() { IsDead = IsDead };
        }

        private void KeyGet(Input input)
        {
            if (input.eB)
            {
                if (IsCaught)
                {
                    if (input.AT)
                    {
                        CenterY = CenterY - 5;
                        int r = Main.rand.Next() % 1;
                        int rx = (Main.rand.Next() % 5) + 1;
                        int ry = (Main.rand.Next() % 5) + 1;

                        if (r == 0)
                        {
                            DX = (int)(rx * Main.RunningSpeedFactor);
                            DY = (int)(-ry * Main.RunningSpeedFactor);
                        }
                        else {
                            DX = (int)(-rx * Main.RunningSpeedFactor);
                            DY = (int)(-ry * Main.RunningSpeedFactor);
                        }
                    }
                    else
                    {
                        CenterY = CenterY - 5;

                        //初速設定？
                        switch (baccel)
                        {
                            case 0:
                                DX = (int)((2 + Level) * AccelVector * Main.RunningSpeedFactor);
                                DY = (int)(-(2 + Level) * Main.RunningSpeedFactor);
                                break;
                            case 1:
                                DX = (int)((3 + Level) * AccelVector * Main.RunningSpeedFactor);
                                DY = (int)(-(3 + Level) * Main.RunningSpeedFactor);
                                break;
                            case 2:
                                DX = (int)((4 + Level) * AccelVector * Main.RunningSpeedFactor);
                                DY = (int)(-(3 + Level) * Main.RunningSpeedFactor);
                                break;
                            case 3:
                                DX = (int)((5 + Level) * AccelVector * Main.RunningSpeedFactor);
                                DY = (int)(-(3 + Level) * Main.RunningSpeedFactor);
                                break;
                        }
                    }
                    IsCaught = false;
                    bar.IsBallCatch = false;
                }
            }
        }

        public void SetBarAccel(Bar bar)
        {
            if (bar.Accel >= 0)
            {
                AccelVector = 1; //デフォルトで右上に発射
            }
            else
            {
                AccelVector = -1;
            }
        }

        /// <summary>
        /// ボールの位置を更新する．上左右壁面との衝突も管理する．
        /// </summary>
        private void Move()
        {
            PlaySound = false;

            CenterX += DX;
            CenterY += DY;

            if (CenterX < Width / 2)
            {
                CenterX = Width / 2;
                DX *= -1;

                PlaySound = true;
            }

            if (CenterX > dInfo.Width - Width / 2)
            {
                CenterX = dInfo.Width - Width / 2;
                DX *= -1;
                PlaySound = true;
            }

            if (CenterY < Height / 2 + 30)
            {
                CenterY = Height / 2 + 30;
                DY *= -1;
                PlaySound = true;
            }

            if (CenterY > dInfo.Height)
                IsDead = true;
        }

        internal void Reset()
        {
            Penetrability = EPenetrability.NON_PENETRATING;
            CenterX = dInfo.Width / 2 + 30;
            CenterY = 540 - Height + 2;
            OldY = CenterY;
            DX = 0;
            DY = 0;
            IsCaught = true;
            IsDead = false;
            Level -= 5;
            if (Level < 1)
                Level = 1;
            CatchXOffset = 0;
            baccel = 0;
            AccelVector = 0;
        }

        internal void PowerUp() // アイテム取得による貫通化
        {
            if (!Main.PenetrationEnables) return;
            if (!IsSmall)
                Penetrability = EPenetrability.PENETRATING;
            PenetratingCount = 150;
        }

        internal void Penetration() // バー中央ヒットによる貫通化
        {
            if (!Main.PenetrationEnables) return;

            Penetrability = EPenetrability.PENETRATING;
            PenetratingCount = 50;
        }

        internal void Increse(Ball mainball, int ballX, int ballY)
        {
            IsSmall = true;
            IsNewCount = 30;
            IsCaught = false;

            double mainBallSpeed = Math.Sqrt(Math.Pow(mainball.DX, 2) + Math.Pow(mainball.DY, 2));

            int degree = Main.rand.Next(0, 360);

            double radian = 2 * Math.PI / 360d * degree;

            DX = (int)(Math.Cos(radian) * mainBallSpeed);
            DY = (int)(Math.Sin(radian) * mainBallSpeed);

            CenterX = ballX;
            CenterY = ballY;
        }

        public void UpdateOverlapping()
        {
            LinkedList<Ball> removes = new LinkedList<Ball>();
            foreach (var ball in OverlappingBalls)
            {
                if (!Collision.BallsIsOverlapping(this, ball))
                    removes.AddLast(ball);
            }

            foreach (var removeBall in removes)
            {
                OverlappingBalls.Remove(removeBall);
            }
        }

        public void BeginOverlapping(Ball other)
        {
            OverlappingBalls.AddLast(other);
        }

        public bool IsOverlapping(Ball other)
        {
            return OverlappingBalls.Contains(other);
        }
    }
}
