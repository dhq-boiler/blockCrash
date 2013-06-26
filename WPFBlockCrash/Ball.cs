using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WPFBlockCrash
{
    class Ball
    {
        public bool ballstop { get; set; }
        public int xoffset { get; set; }
        public int baccel { get; set; } 
        public int acbectl { get; set; } // 加速の向き

        public enum EPenetrability
        {
            NON_PENETRATING,
            PENETRATING
        }

        public Ball(DisplayInfo dInfo)
        {
            this.dInfo = dInfo;
            gh = new ImageSource[4];
            gh[0] = new BitmapImage(new Uri(Main.ResourceDirectory, "ball_a.png"));
            gh[1] = new BitmapImage(new Uri(Main.ResourceDirectory, "ball2.png"));
            gh[2] = new BitmapImage(new Uri(Main.ResourceDirectory, "ball3.png"));
            gh[3] = new BitmapImage(new Uri(Main.ResourceDirectory, "ball3.png"));

            Width = (int)gh[0].Width;
            Height = (int)gh[0].Height;

            X = dInfo.Width / 2 + 30;
            Y = 540 - Height + 2;
            DX = 0;
            DY = 0;
            Radius = 60;
            ActCount = 0;
            OldY = Y;
            IsDead = false;
            PlaySound = false;
            Penetrability = EPenetrability.NON_PENETRATING;
            PenetratingCount = 0;
            IsSmall = false;
            IsNewCount = 0;
            Level = 1;
            ballstop = true;
            xoffset = 0;
            baccel = 0;
            acbectl = 0;
        }

        public void Draw(DrawingContext dc)
        {
            ImageSource src = null;

            if (Penetrability == EPenetrability.PENETRATING)
                if(IsSmall)
                    src = gh[3];
                else
                    src = gh[1];
            else if (IsSmall)
                src = gh[2];
            else
                src = gh[0];

            DrawUtil.DrawGraph(dc, X - Width / 2, Y - Height / 2, src);
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

        internal void spchange()
        {
            if (IsSmall)
                return;
            //Random rand = new Random(Environment.TickCount);
            int r = Main.rand.Next() % 5;
            DX += r - 6;
            DY += (10 - r) - 6;
        }

        internal bool Process(Input input, DrawingContext dc)
        {
            if (ActCount != 0 || IsSmall)
                Move();

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

            Draw(dc);

            return IsDead;
        }

        private void KeyGet(Input input)
        {
            if (input.eB)
            {
                if (ActCount == 0 && !IsSmall || ballstop)
                {
                    if (input.AT) {
                        Y = Y - 5;
                        int r = Main.rand.Next() % 1;
                        int rx = (Main.rand.Next() % 5) + 1;
                        int ry = (Main.rand.Next() % 5) + 1;
                        if (r == 0)
                        {
                            DX = rx;
                            DY = -ry;
                        }
                        else {
                            DX = -rx;
                            DY = -ry;
                        }
                    }
                    else
                    {
                        Y = Y - 5;
                        switch (baccel)
                        {
                            case 0: DX = (2 + Level) * acbectl;
                                DY = -(2 + Level);
                                break;
                            case 1: DX = (3 + Level) * acbectl;
                                DY = -(3 + Level);
                                break;
                            case 2: DX = (4 + Level) * acbectl;
                                DY = -(3 + Level);
                                break;
                            case 3: DX = (5 + Level) * acbectl;
                                DY = -(3 + Level);
                                break;
                        }
                    }
                    ActCount = 1;
                    ballstop = false;
                }
            }
        }
        public void BarAccel(int bac)
        {
            baccel = bac;
            if (baccel == 0)
            {
                acbectl = 1;
            }
            else if (baccel > 0)
                acbectl = 1;
            else
            {
                acbectl = -1;
                baccel = -baccel;
            }
        }

        private void Move()
        {
            PlaySound = false;

            X += DX;
            Y += DY;

            if (X < Width / 2)
            {
                X = Width / 2;
                DX *= -1;

                PlaySound = true;
            }

            if (X > dInfo.Width - Width / 2)
            {
                X = dInfo.Width - Width / 2;
                DX *= -1;
                PlaySound = true;
            }

            if (Y < Height / 2 + 30)
            {
                Y = Height / 2 + 30;
                DY *= -1;
                PlaySound = true;
            }

            if (Y > dInfo.Height)
                IsDead = true;
        }


        private ImageSource[] gh;
        private DisplayInfo dInfo;
        public int ActCount { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int DX { get; set; }
        public int DY { get; set; }
        public int Level { get; set; }
        public int Radius { get; set; }
        public int OldY { get; set; }
        public bool IsDead { get; set; }
        public bool PlaySound { get; set; }
        public EPenetrability Penetrability { get; set; }

        public int PenetratingCount { get; set; }

        public bool IsSmall { get; set; }
        public int IsNewCount { get; set; }

        internal void Reset()
        {
            Penetrability = EPenetrability.NON_PENETRATING;
            X = dInfo.Width / 2 + 30;
            Y = 540 - Height + 2;
            OldY = Y;
            DX = 0;
            DY = 0;
            ActCount = 0;
            IsDead = false;
            Radius = 1;
            Level -= 5;
            if (Level < 1)
                Level = 1;
            xoffset = 0;
            baccel = 0;
            acbectl = 0;
        }

        internal void PowerUp() // アイテム取得による貫通化
        {
            if (!IsSmall)
                Penetrability = EPenetrability.PENETRATING;
            PenetratingCount = 150;
        }

        internal void Penetration() // バー中央ヒットによる貫通化
        {
            Penetrability = EPenetrability.PENETRATING;
            PenetratingCount = 50;
        }

        internal void Increse(int ballX, int ballY)
        {
            IsSmall = true;
            IsNewCount = 30; 
            int r = (Main.rand.Next() ^ Main.rand.Next()) % 7;
            X = ballX;
            Y = ballY;
            DX += r - 3;
            DY += (6 - r) - 2;
            if (DY == 0)
                DY = -1;
        }
    }
}
