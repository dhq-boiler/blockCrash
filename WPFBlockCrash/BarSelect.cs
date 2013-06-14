using System;
using System.Collections.Generic;
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
        private ImageSource[] barGh;
        private ImageSource bSelectGh;
        private bool selectFlag;
        private bool decisionFlag;
        private SoundPlayer sh;
        private SoundPlayer dh;
        private int keyCount;
        private int autoCount;


        public BarSelect()
        {
            barGh = new ImageSource[3];

            mBar = 1;
            keyCount = 8;

            barGh[0] = new BitmapImage(new Uri(Main.ResourceDirectory, "bar.bmp"));
            barGh[1] = new BitmapImage(new Uri(Main.ResourceDirectory, "barsecond.bmp"));
            barGh[2] = new BitmapImage(new Uri(Main.ResourceDirectory, "barthird.bmp"));
            bSelectGh = new BitmapImage(new Uri(Main.ResourceDirectory, "barselect.png"));

            selectFlag = false;
            decisionFlag = false;

            IsDead = false;

            autoCount = 0;

            sh = new SoundPlayer(Main.ResourceDirectory + "bound.wav");
            dh = new SoundPlayer(Main.ResourceDirectory + "demolish.wav");
        }

        public bool Process(Input input, DrawingContext dc)
        {
            //キー処理
            KeyGet(input);

            //描画処理
            Draw(dc);

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

        private void Draw(DrawingContext dc)
        {
            DrawUtil.DrawGraph(dc, 30, 0, bSelectGh);

            switch (mBar)
            {
                case 1:
                    {
                        DrawUtil.DrawString(dc, 440, 240, "BAR NAME：", RGB(255, 180, 0));
                        DrawUtil.DrawString(dc, 560, 240, "ノーマルバー", RGB(255, 255, 128));
                        DrawUtil.DrawString(dc, 440, 300, "BALL SPEED：", RGB(255, 180, 0));
                        DrawUtil.DrawString(dc, 570, 300, "★", RGB(255, 180, 128));
                        DrawUtil.DrawString(dc, 440, 360, "TECHNICAL：", RGB(255, 180, 0));
                        DrawUtil.DrawString(dc, 570, 360, "★", RGB(255, 180, 128));
                        DrawUtil.DrawString(dc, 440, 420, "DIFFICULTY：", RGB(255, 180, 0));
                        DrawUtil.DrawString(dc, 570, 420, "★", RGB(255, 180, 128));
                    }
                    break;
                case 2:
                    {
                        DrawUtil.DrawString(dc, 440, 240, "BAR NAME：", RGB(255, 180, 0));
                        DrawUtil.DrawString(dc, 560, 240, "２号機", RGB(255, 255, 128));
                        DrawUtil.DrawString(dc, 440, 300, "BALL SPEED：", RGB(255, 180, 0));
                        DrawUtil.DrawString(dc, 570, 300, "★　★　★", RGB(255, 180, 128));
                        DrawUtil.DrawString(dc, 440, 360, "TECHNICAL：", RGB(255, 180, 0));
                        DrawUtil.DrawString(dc, 570, 360, "★　★", RGB(255, 180, 128));
                        DrawUtil.DrawString(dc, 440, 420, "DIFFICULTY：", RGB(255, 180, 0));
                        DrawUtil.DrawString(dc, 570, 420, "★　★", RGB(255, 180, 128));
                    }
                    break;
                case 3:
                    {
                        DrawUtil.DrawString(dc, 440, 240, "BAR NAME：", RGB(255, 180, 0));
                        DrawUtil.DrawString(dc, 560, 240, "３つめ", RGB(255, 255, 128));
                        DrawUtil.DrawString(dc, 440, 300, "BALL SPEED：", RGB(255, 180, 0));
                        DrawUtil.DrawString(dc, 570, 300, "★　★　★　★　★", RGB(255, 0, 128));
                        DrawUtil.DrawString(dc, 440, 360, "TECHNICAL：", RGB(255, 180, 0));
                        DrawUtil.DrawString(dc, 570, 360, "★　★　★", RGB(255, 0, 128));
                        DrawUtil.DrawString(dc, 440, 420, "DIFFICULTY：", RGB(255, 180, 0));
                        DrawUtil.DrawString(dc, 570, 420, "★　★　★　★　★", RGB(255, 0, 128));
                    }
                    break;
            }

            for (int i = 0; i < 3; ++i)
            {
                if (i == 2)
                    DrawUtil.DrawGraph(dc, 125, 200 + i * 120, barGh[i]);
                else
                    DrawUtil.DrawGraph(dc, 100, 200 + i * 120, barGh[i]);
            }

            DrawUtil.DrawBox(dc, 80, 190 + (mBar - 1) * 120, 250, 224 + (mBar - 1) * 120, RGB(255, 20, 30));
            DrawUtil.DrawBox(dc, 400, 220, 750, 478, RGB(255, 20, 30));
        }

        private Color RGB(byte r, byte g, byte b)
        {
            return Color.FromRgb(r, g, b);
        }

        public int mBar { get; set; }
        public bool IsDead { get; set; }
    }
}
