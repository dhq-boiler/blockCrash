using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    enum EStageType
    {
        UNKNOWN,
        ONAJIMISAN,
        FOURTOWER,
        CROSSCROSS,
        LAWOFCYCLES,
        PRODUCTORISUS
    }

    class StageSelect : IInputable
    {
        private Image[] bargh;
        private Image ballgh;
        private Image[] stagegh;
        private Image[] sdetailgh;
        private Image sselectgh;
        private Image cleargh;
        private bool[] clear;
        private SoundPlayer sh;
        private SoundPlayer dh;
        private int autocount;

        private readonly Font font = new Font("Consolas", 16);

        public int Score { get; set; }
        public int Stock { get; set; }
        private int Stage;
        public int Bar { get; set; }

        public bool IsDead { get; set; }

        private DisplayInfo dInfo;
        private IOperator Operator;

        public StageSelect(DisplayInfo dInfo, IOperator Operator)
        {
            this.dInfo = dInfo;
            this.Operator = Operator;

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

            autocount = 0;
        }

        public ProcessResult Process(Input input, Graphics g, UserChoice uc, TakeOver takeOver)
        {
            //キー処理
            KeyGet(input);

            //描画処理
            Draw(g);

            if (IsDead)
            {
                uc.StageType = (EStageType)Stage;
                return new ProcessResult()
                {
                    IsDead = IsDead,
                    NextState = new Control(uc, takeOver, dInfo, input, Operator)
                    {
                        IsPlaying = true,
                    },
                    UserChoice = uc,
                    TakeOver = takeOver
                };
            }
            else
                return new ProcessResult() { IsDead = IsDead, NextState = this };
        }

        private void Draw(Graphics g)
        {
            g.DrawImage(sselectgh, 0, 0);
            g.DrawImage(sdetailgh[Stage - 1], 400, 320);

            switch (Stage)
            {
                case 1:
                    DrawStageTitle(g, "オナジミサン");
                    break;
                case 2:
                    DrawStageTitle(g, "4つの塔");
                    break;
                case 3:
                    DrawStageTitle(g, "クロスクロス");
                    break;
                case 4:
                    DrawStageTitle(g, "円環の理");
                    break;
                case 5:
                    DrawStageTitle(g, "製作者は私達です。");
                    break;
            }

            for (int i = 0; i < 5; ++i)
            {
                g.DrawImage(stagegh[i], 60 + i * 120, 200);
            }

            if (clear[Stage - 1])
            {
                g.DrawImage(cleargh, 700, 320);
            }

            g.DrawRectangle(new System.Drawing.Pen(DrawUtil.BrushRGB(255, 20, 30)), 60 + (Stage - 1) * 120, 200, 100, 80);
            g.DrawRectangle(new System.Drawing.Pen(DrawUtil.BrushRGB(255, 20, 30)), 400, 320, 350, 270);
            g.DrawImage(bargh[Bar - 1], 40, 460);
            g.DrawString(string.Format("SCORE：{0}", Score), font, DrawUtil.BrushRGB(255, 120, 0), 40, 500);
            g.DrawString(string.Format("STOCK：{0}", Stock), font, DrawUtil.BrushRGB(255, 120, 0), 40, 540);
        }

        private void DrawStageTitle(Graphics g, string stageTitle)
        {
            g.DrawString(stageTitle, font, DrawUtil.BrushRGB(255, 120, 0), 40, 340);
        }

        private void KeyGet(Input input)
        {
            Operator.SelectStage(ref Stage, input, ref autocount);
            //if (input.rB)
            //{
            //    if (input.AT)
            //        ++autocount;

            //    ++Stage;

            //    if (Stage > 5)
            //        Stage = 1;

            //    input.rB = false;
            //}

            //if (input.lB)
            //{
            //    if (input.AT)
            //        ++autocount;

            //    --Stage;

            //    if (Stage < 1)
            //        Stage = 5;

            //    input.lB = false;
            //}

            //if (input.barx >= 50 && input.barx < 700d / 5d * 1d)
            //{
            //    Stage = 1;
            //}
            //else if (input.barx >= 700d / 5d * 1d && input.barx < 700d / 5d * 2d)
            //{
            //    Stage = 2;
            //}
            //else if (input.barx >= 700d / 5d * 2d && input.barx < 700d / 5d * 3d)
            //{
            //    Stage = 3;
            //}
            //else if (input.barx >= 700d / 5d * 3d && input.barx < 700d / 5d * 4d)
            //{
            //    Stage = 4;
            //}
            //else if (input.barx >= 700d / 5d * 4d && input.barx < 700d)
            //{
            //    Stage = 5;
            //}

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
