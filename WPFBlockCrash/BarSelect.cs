using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WPFBlockCrash
{
    class BarSelect
    {
        private Image[] barGh;
        private Image bSelectGh;
        private bool selectFlag;
        private bool decisionFlag;
        private SoundPlayer sh;
        private SoundPlayer dh;
        private int keyCount;
        private int autoCount;

        private readonly Font font = new Font("Consolas", 20);

        public BarSelect()
        {
            barGh = new Image[3];

            mBar = 1;
            keyCount = 8;

            barGh[0] = new Bitmap(Main.ResourceDirectory + "bar.bmp");
            barGh[1] = new Bitmap(Main.ResourceDirectory + "barsecond.bmp");
            barGh[2] = new Bitmap(Main.ResourceDirectory + "barthird.bmp");
            bSelectGh = new Bitmap(Main.ResourceDirectory + "barselect.png");

            selectFlag = false;
            decisionFlag = false;

            IsDead = false;

            autoCount = 0;

            sh = new SoundPlayer(Main.ResourceDirectory + "bound.wav");
            dh = new SoundPlayer(Main.ResourceDirectory + "demolish.wav");
        }

        public bool Process(Input input, Graphics g)
        {
            //キー処理
            KeyGet(input);

            //描画処理
            Draw(g);

            return IsDead;
        }

        private void KeyGet(Input input)
        {
            if (input.rB)
            {
                if (input.AT)
                    ++autoCount;

                ++mBar;

                if (mBar > 3)
                    mBar = 1;

                input.rB = false;
            }

            if (input.lB)
            {
                if (input.AT)
                    ++autoCount;

                --mBar;

                if (mBar < 1)
                    mBar = 3;

                input.lB = false;
            }

            if (input.barx < 700d / 3d * 1d && input.barx >= 50)
            {
                mBar = 1;
            }
            else if (input.barx >= 700d / 3d * 1d && input.barx < 700d / 3d * 2d)
            {
                mBar = 2;
            }
            else if (input.barx >= 700d / 3d * 2d && input.barx < 700d)
            {
                mBar = 3;
            }

            if (input.AT)
            {
                if (input.eB && autoCount > 10)
                {
                    IsDead = true;
                    input.eB = false;
                    autoCount = 0;
                }
            }
            else if (input.eB)
            {
                IsDead = true;
                input.eB = false;
            }
        }

        private void Draw(Graphics g)
        {
            //DrawUtil.DrawGraph(dc, 30, 0, bSelectGh);
            g.DrawImage(bSelectGh, 30, 0);

            switch (mBar)
            {
                case 1:
                    {
                        //DrawUtil.DrawString(dc, 440, 240, "BAR NAME：", RGB(255, 180, 0));
                        g.DrawString("BAR NAME：", font, RGB(255, 180, 0), new PointF(440, 240));
                        //DrawUtil.DrawString(dc, 560, 240, "ノーマルバー", RGB(255, 255, 128));
                        g.DrawString("ノーマルバー", font, RGB(255, 255, 128), new PointF(560, 240));
                        //DrawUtil.DrawString(dc, 440, 300, "BALL SPEED：", RGB(255, 180, 0));
                        g.DrawString("BALL SPEED：", font, RGB(255, 180, 0), new PointF(440, 300));
                        //DrawUtil.DrawString(dc, 570, 300, "★", RGB(255, 180, 128));
                        g.DrawString("★", font, RGB(255, 180, 128), new PointF(570, 300));
                        //DrawUtil.DrawString(dc, 440, 360, "TECHNICAL：", RGB(255, 180, 0));
                        g.DrawString("TECHNICAL：", font, RGB(255, 180, 0), new PointF(440, 360));
                        //DrawUtil.DrawString(dc, 570, 360, "★", RGB(255, 180, 128));
                        g.DrawString("★", font, RGB(255, 180, 128), new PointF(570, 360));
                        //DrawUtil.DrawString(dc, 440, 420, "DIFFICULTY：", RGB(255, 180, 0));
                        g.DrawString("DIFFICULTY：", font, RGB(255, 180, 0), new PointF(440, 420));
                        //DrawUtil.DrawString(dc, 570, 420, "★", RGB(255, 180, 128));
                        g.DrawString("★", font, RGB(255, 180, 128), new PointF(570, 420));
                    }
                    break;
                case 2:
                    {
                        //DrawUtil.DrawString(dc, 440, 240, "BAR NAME：", RGB(255, 180, 0));
                        g.DrawString("BAR NAME：", font, RGB(255, 180, 0), new PointF(440, 240));
                        //DrawUtil.DrawString(dc, 560, 240, "２号機", RGB(255, 255, 128));
                        g.DrawString("2号機", font, RGB(255, 255, 128), new PointF(560, 240));
                        //DrawUtil.DrawString(dc, 440, 300, "BALL SPEED：", RGB(255, 180, 0));
                        g.DrawString("BALL SPEED：", font, RGB(255, 180, 0), new PointF(440, 300));
                        //DrawUtil.DrawString(dc, 570, 300, "★　★　★", RGB(255, 180, 128));
                        g.DrawString("★　★　★", font, RGB(255, 180, 128), new PointF(570, 300));
                        //DrawUtil.DrawString(dc, 440, 360, "TECHNICAL：", RGB(255, 180, 0));
                        g.DrawString("TECHNICAL：", font, RGB(255, 180, 0), new PointF(440, 360));
                        //DrawUtil.DrawString(dc, 570, 360, "★　★", RGB(255, 180, 128));
                        g.DrawString("★　★", font, RGB(255, 180, 128), new PointF(570, 360));
                        //DrawUtil.DrawString(dc, 440, 420, "DIFFICULTY：", RGB(255, 180, 0));
                        g.DrawString("DIFFICULTY：", font, RGB(255, 180, 0), new PointF(440, 420));
                        //DrawUtil.DrawString(dc, 570, 420, "★　★", RGB(255, 180, 128));
                        g.DrawString("★　★", font, RGB(255, 180, 128), new PointF(570, 420));
                    }
                    break;
                case 3:
                    {
                        //DrawUtil.DrawString(dc, 440, 240, "BAR NAME：", RGB(255, 180, 0));
                        g.DrawString("BAR NAME：", font, RGB(255, 180, 0), new PointF(440, 240));
                        //DrawUtil.DrawString(dc, 560, 240, "３つめ", RGB(255, 255, 128));
                        g.DrawString("３つめ", font, RGB(255, 255, 128), new PointF(560, 240));
                        //DrawUtil.DrawString(dc, 440, 300, "BALL SPEED：", RGB(255, 180, 0));
                        g.DrawString("BALL SPEED：", font, RGB(255, 180, 0), new PointF(440, 300));
                        //DrawUtil.DrawString(dc, 570, 300, "★　★　★　★　★", RGB(255, 0, 128));
                        g.DrawString("★　★　★　★　★", font, RGB(255, 0, 128), new PointF(570, 300));
                        //DrawUtil.DrawString(dc, 440, 360, "TECHNICAL：", RGB(255, 180, 0));
                        g.DrawString("TECHNICAL：", font, RGB(255, 180, 0), new PointF(440, 360));
                        //DrawUtil.DrawString(dc, 570, 360, "★　★　★", RGB(255, 0, 128));
                        g.DrawString("★　★　★", font, RGB(255, 0, 128), new PointF(570, 360));
                        //DrawUtil.DrawString(dc, 440, 420, "DIFFICULTY：", RGB(255, 180, 0));
                        g.DrawString("DIFFICULTY：", font, RGB(255, 180, 0), new PointF(440, 420));
                        //DrawUtil.DrawString(dc, 570, 420, "★　★　★　★　★", RGB(255, 0, 128));
                        g.DrawString("★　★　★　★　★", font, RGB(255, 0, 128), new PointF(570, 420));
                    }
                    break;
            }

            for (int i = 0; i < 3; ++i)
            {
                if (i == 2)
                    //DrawUtil.DrawGraph(dc, 125, 200 + i * 120, barGh[i]);
                    g.DrawImage(barGh[i], 125, 200 + i * 120);
                else
                    //DrawUtil.DrawGraph(dc, 100, 200 + i * 120, barGh[i]);
                    g.DrawImage(barGh[i], 100, 200 + i * 120);
            }

            //DrawUtil.DrawBox(dc, 80, 190 + (mBar - 1) * 120, 250, 224 + (mBar - 1) * 120, RGB(255, 20, 30));
            g.DrawRectangle(new System.Drawing.Pen(System.Drawing.Color.FromArgb(255, 20, 30)), 80, 190 + (mBar - 1) * 120, 250, 224 + (mBar - 1) * 120);
            //DrawUtil.DrawBox(dc, 400, 220, 750, 478, RGB(255, 20, 30));
            g.DrawRectangle(new System.Drawing.Pen(System.Drawing.Color.FromArgb(255, 20, 30)), 400, 220, 750, 478);
        }

        //private Color RGB(byte r, byte g, byte b)
        //{
        //    return Color.FromRgb(r, g, b);
        //}

        private System.Drawing.Brush RGB(byte r, byte g, byte b)
        {
            return new SolidBrush(System.Drawing.Color.FromArgb(r, g, b));
        }

        public int mBar { get; set; }
        public bool IsDead { get; set; }
    }
}
