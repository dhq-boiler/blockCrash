using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    class BarSelect
    {
        private Image[] barGh;
        private Image bSelectGh;
        private SoundPlayer sh;
        private SoundPlayer dh;
        private int autoCount;
        public int mBar { get; set; }
        public bool IsDead { get; set; }

        private readonly Font font = new Font("Consolas", 16);

        public BarSelect()
        {
            barGh = new Image[3];

            mBar = 1;

            barGh[0] = new Bitmap(Main.ResourceDirectory + "bar.bmp");
            barGh[1] = new Bitmap(Main.ResourceDirectory + "barsecond.bmp");
            barGh[2] = new Bitmap(Main.ResourceDirectory + "barthird.bmp");
            bSelectGh = new Bitmap(Main.ResourceDirectory + "barselect.png");
            sh = new SoundPlayer(Main.ResourceDirectory + "bound.wav");
            dh = new SoundPlayer(Main.ResourceDirectory + "demolish.wav");

            IsDead = false;
            autoCount = 0;
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
            g.DrawImage(bSelectGh, 30, 0);

            switch (mBar)
            {
                case 1:
                    {
                        g.DrawString("BAR NAME：", font, DrawUtil.BrushRGB(255, 180, 0), new PointF(440, 240));
                        g.DrawString("ノーマルバー", font, DrawUtil.BrushRGB(255, 255, 128), new PointF(560, 240));
                        g.DrawString("BALL SPEED：", font, DrawUtil.BrushRGB(255, 180, 0), new PointF(440, 300));
                        g.DrawString("★", font, DrawUtil.BrushRGB(255, 180, 128), new PointF(570, 300));
                        g.DrawString("TECHNICAL：", font, DrawUtil.BrushRGB(255, 180, 0), new PointF(440, 360));
                        g.DrawString("★", font, DrawUtil.BrushRGB(255, 180, 128), new PointF(570, 360));
                        g.DrawString("DIFFICULTY：", font, DrawUtil.BrushRGB(255, 180, 0), new PointF(440, 420));
                        g.DrawString("★", font, DrawUtil.BrushRGB(255, 180, 128), new PointF(570, 420));
                    }
                    break;
                case 2:
                    {
                        g.DrawString("BAR NAME：", font, DrawUtil.BrushRGB(255, 180, 0), new PointF(440, 240));
                        g.DrawString("2号機", font, DrawUtil.BrushRGB(255, 255, 128), new PointF(560, 240));
                        g.DrawString("BALL SPEED：", font, DrawUtil.BrushRGB(255, 180, 0), new PointF(440, 300));
                        g.DrawString("★　★　★", font, DrawUtil.BrushRGB(255, 180, 128), new PointF(570, 300));
                        g.DrawString("TECHNICAL：", font, DrawUtil.BrushRGB(255, 180, 0), new PointF(440, 360));
                        g.DrawString("★　★", font, DrawUtil.BrushRGB(255, 180, 128), new PointF(570, 360));
                        g.DrawString("DIFFICULTY：", font, DrawUtil.BrushRGB(255, 180, 0), new PointF(440, 420));
                        g.DrawString("★　★", font, DrawUtil.BrushRGB(255, 180, 128), new PointF(570, 420));
                    }
                    break;
                case 3:
                    {
                        g.DrawString("BAR NAME：", font, DrawUtil.BrushRGB(255, 180, 0), new PointF(440, 240));
                        g.DrawString("３つめ", font, DrawUtil.BrushRGB(255, 255, 128), new PointF(560, 240));
                        g.DrawString("BALL SPEED：", font, DrawUtil.BrushRGB(255, 180, 0), new PointF(440, 300));
                        g.DrawString("★　★　★　★　★", font, DrawUtil.BrushRGB(255, 0, 128), new PointF(570, 300));
                        g.DrawString("TECHNICAL：", font, DrawUtil.BrushRGB(255, 180, 0), new PointF(440, 360));
                        g.DrawString("★　★　★", font, DrawUtil.BrushRGB(255, 0, 128), new PointF(570, 360));
                        g.DrawString("DIFFICULTY：", font, DrawUtil.BrushRGB(255, 180, 0), new PointF(440, 420));
                        g.DrawString("★　★　★　★　★", font, DrawUtil.BrushRGB(255, 0, 128), new PointF(570, 420));
                    }
                    break;
            }

            for (int i = 0; i < 3; ++i)
            {
                if (i == 2)
                    g.DrawImage(barGh[i], 125, 200 + i * 120);
                else
                    g.DrawImage(barGh[i], 100, 200 + i * 120);
            }

            g.DrawRectangle(new Pen(DrawUtil.BrushRGB(255, 20, 30)), 80, 190 + (mBar - 1) * 120, 170, 40);
            g.DrawRectangle(new Pen(DrawUtil.BrushRGB(255, 20, 30)), 400, 220, 370, 250);
        }
    }
}
