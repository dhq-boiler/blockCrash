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
    class StageSelect
    {
        private Image[] bargh;
        private Image ballgh;
        private Image[] stagegh;
        private Image[] sdetailgh;
        private Image sselectgh;
        private Image cleargh;
        private bool[] clear;
        private bool selectFlag;
        private bool decisionFlag;
        private SoundPlayer sh;
        private SoundPlayer dh;
        private int keycount;
        private int enterCount;
        private int autocount;

        private readonly Font

        public int Score { get; set; }
        public int Stock { get; set; }
        public int Stage { get; set; }
        public int Bar { get; set; }

        public bool IsDead { get; set; }

        public StageSelect()
        {
            bargh = new Image[3];
            stagegh = new Image[6];
            sdetailgh = new Image[6];
            clear = new bool[6];

            Stage = 1;

            bargh[0] = new Bitmap(Main.ResourceDirectory + "bar.bmp");
            bargh[1] = new Bitmap(Main.ResourceDirectory + "barsecond.bmp");
            bargh[2] = new Bitmap(Main.ResourceDirectory + "barthird.bmp");

            ballgh = new Bitmap(Main.ResourceDirectory + "ball_b.png");

            stagegh[0] = new Bitmap(Main.ResourceDirectory + "stage1mini.png");
            stagegh[1] = new Bitmap(Main.ResourceDirectory + "stage2mini.png");
            stagegh[2] = new Bitmap(Main.ResourceDirectory + "stage3mini.png");
            stagegh[3] = new Bitmap(Main.ResourceDirectory + "stage4mini.png");
            stagegh[4] = new Bitmap(Main.ResourceDirectory + "stage5mini.png");
            stagegh[5] = new Bitmap(Main.ResourceDirectory + "ball.png");

            sdetailgh[0] = new Bitmap(Main.ResourceDirectory + "stage1.png");
            sdetailgh[1] = new Bitmap(Main.ResourceDirectory + "stage2.png");
            sdetailgh[2] = new Bitmap(Main.ResourceDirectory + "stage3.png");
            sdetailgh[3] = new Bitmap(Main.ResourceDirectory + "stage4.png");
            sdetailgh[4] = new Bitmap(Main.ResourceDirectory + "stage5.png");
            sdetailgh[5] = new Bitmap(Main.ResourceDirectory + "ball.png");

            sselectgh = new Bitmap(Main.ResourceDirectory + "stageselect.png");
            cleargh = new Bitmap(Main.ResourceDirectory + "clearstar.png");

            selectFlag = false;
            decisionFlag = false;

            IsDead = false;

            sh = new SoundPlayer(Main.ResourceDirectory + "bound.wav");
            dh = new SoundPlayer(Main.ResourceDirectory + "demolish.wav");

            for (int i = 0; i < 6; ++i)
            {
                clear[i] = false;
            }

            Score = 0;
            Stock = 2;
            Bar = 1;

            enterCount = 0;
            autocount = 0;
        }

        public bool Process(Input input, Graphics g)
        {
            //キー処理
            KeyGet(input);

            //描画処理
            Draw(g);

            return IsDead;
        }

        private void Draw(Graphics g)
        {
            //DrawUtil.DrawGraph(dc, 0, 0, sselectgh);
            g.DrawImage(sselectgh, 0, 0);
            //DrawUtil.DrawGraph(dc, 400, 320, sdetailgh[Stage - 1]);
            g.DrawImage(sdetailgh[Stage - 1], 400, 320);

            switch (Stage)
            {
                case 1:
                    //DrawStageTitle(dc, "オナジミサン");
                    DrawStageTitle(g, "オナジミサン");
                    break;
                case 2:
                    DrawStageTitle(dc, "4つの塔");
                    break;
                case 3:
                    DrawStageTitle(dc, "クロスクロス");
                    break;
                case 4:
                    DrawStageTitle(dc, "円環の理");
                    break;
                case 5:
                    DrawStageTitle(dc, "製作は私達です。");
                    break;
            }

            for (int i = 0; i < 5; ++i)
            {
                DrawUtil.DrawGraph(dc, 60 + i * 120, 200, stagegh[i]);
            }

            if (clear[Stage - 1])
            {
                DrawUtil.DrawGraph(dc, 700, 320, cleargh);
            }

            DrawUtil.DrawBox(dc, 60 + (Stage - 1) * 120, 200, 160 + (Stage - 1) * 120, 270, RGB(255, 20, 30));
            DrawUtil.DrawBox(dc, 400, 320, 750, 578, RGB(255, 20, 30));
            DrawUtil.DrawGraph(dc, 40, 460, bargh[Bar - 1]);
            DrawUtil.DrawString(dc, 40, 500, string.Format("SCORE：{0}", Score),RGB(255, 120, 0));
            DrawUtil.DrawString(dc, 40, 540, string.Format("STOCK：{0}", Stock), RGB(255, 120, 0));
        }

        private void DrawStageTitle(Graphics g, string p)
        {
            g.DrawString(p, font, )
        }

        private void DrawStageTitle(DrawingContext dc, string stageTitle)
        {
            DrawUtil.DrawString(dc, 40, 340, stageTitle, RGB(255, 120, 0));
        }

        private Color RGB(byte r, byte g, byte b)
        {
            return Color.FromRgb(r, g, b);
        }

        private void KeyGet(Input input)
        {
            if (input.rB)
            {
                if (input.AT)
                    ++autocount;

                ++Stage;

                if (Stage > 5)
                    Stage = 1;

                input.rB = false;
            }

            if (input.lB)
            {
                if (input.AT)
                    ++autocount;

                --Stage;

                if (Stage < 1)
                    Stage = 5;

                input.lB = false;
            }

            if (input.barx >= 50 && input.barx < 700d / 5d * 1d)
            {
                Stage = 1;
            }
            else if (input.barx >= 700d / 5d * 1d && input.barx < 700d / 5d * 2d)
            {
                Stage = 2;
            }
            else if (input.barx >= 700d / 5d * 2d && input.barx < 700d / 5d * 3d)
            {
                Stage = 3;
            }
            else if (input.barx >= 700d / 5d * 3d && input.barx < 700d / 5d * 4d)
            {
                Stage = 4;
            }
            else if (input.barx >= 700d / 5d * 4d && input.barx < 700d)
            {
                Stage = 5;
            }

            if (input.AT)
            {
                if (input.eB && autocount > 10)
                {
                    IsDead = true;
                    input.eB = false;
                    autocount = 0;
                }
            }
            else if (input.eB)
            {
                IsDead = true;
                input.eB = false;
            }
        }

        public void SetValue(int bar, int stage, int score, int stock)
        {
            Bar = bar;
            if(stage != 0)
                clear[stage - 1] = true;
            Score = score;
            Stock = stock;
        }

        internal void Reset()
        {
            for (int i = 0; i < 5; ++i)
            {
                clear[i] = false;
            }

            Score = 0;
            Stock = 2;
        }
    }
}
