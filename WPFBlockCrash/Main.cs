using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{

    class Main
    {
        enum EActType
        {
            TITLE,
            BAR_SELECT,
            STAGE_SELECT,
            CONTROL,
            RANKING
        }

        private StageSelect stageSelect;
        private Control control;
        private Message message;
        private BarSelect barSelect;
        private Title title;
        public Ranking ranking;

        private EActType ActType;

        private int act;
        private int stock;
        private int c;
        private DisplayInfo dInfo;
        public static readonly string ResourceDirectory = Directory.GetCurrentDirectory() + "\\res\\";
        public static readonly Random rand = new Random(Environment.TickCount);
        
        public Main(DisplayInfo dInfo)
        {
            this.dInfo = dInfo;

            title = new Title();
            barSelect = new BarSelect();
            stageSelect = new StageSelect();
            ActType = EActType.TITLE;
            act = 0;
            stock = 0;
            c = 0;
        }

        public void ProcessLoop(Input input, Graphics g)
        {
            g.FillRectangle(Brushes.Black, 0, 0, 800, 600);

            if (input.IsPushedKeys)
            {
                input.rB = input.RB.Output;
                input.lB = input.LB.Output;
                input.eB = input.EB.Output;
            }

            if (input.AT) //自動化状態
            {
                ATMode(input);

                if (input.barx == 50 || (input.eB && input.lB && input.rB))
                {
                    input.AT = false;
                    Restart(input);
                }
            }

            switch (ActType)
            {
                case EActType.TITLE:
                    {
                        if (title.Process(input, g))
                            ActType = EActType.BAR_SELECT;
                    }
                    break;
                case EActType.BAR_SELECT:
                    {
                        if (barSelect.Process(input, g))
                        {
                            stageSelect.SetValue(barSelect.mBar, 0, 0, 2);
                            ActType = EActType.STAGE_SELECT;
                        }
                    }
                    break;
                case EActType.STAGE_SELECT:
                    {
                        if (stageSelect.Process(input, g))
                        {
                            ActType = EActType.CONTROL;
                            stock = stageSelect.Stock;
                            control = new Control(stageSelect.Bar, stageSelect.Stage, stageSelect.Score, stock, dInfo);
                        }
                    }
                    break;
                case EActType.CONTROL:
                    {
                        if (control.Process(input, g))
                        {
                            stock = control.Stock;
                            if (stock > 1)
                            {
                                if (act == 0)
                                {
                                    message = new Message(EMessageType.FAILED, 50, dInfo);
                                    ++act;
                                }

                                if (message.Process(input, g))
                                {
                                    control.Reset(); // 残機を減らしゲームを続行
                                    --stock;
                                    act = 0;
                                    message = null;
                                }
                            }
                            else
                            {
                                if (act == 0)
                                {
                                    message = new Message(EMessageType.GAMEOVER, 120, dInfo);
                                    ++act;
                                }

                                if (message.Process(input, g))
                                {
                                    ActType = EActType.RANKING;
                                    ranking = new Ranking(control.Score,control.Bar, dInfo);
                                }
                            }
                        }
                        else if (control.clear)
                        {
                            if (act == 0)
                            {
                                message = new Message(EMessageType.CLEAR, 200, dInfo);
                                ++act;
                            }

                            if (message.Process(input, g))
                            {
                                ActType = EActType.RANKING;
                                ranking = new Ranking(control.Score, control.Bar, dInfo);
                            }
                        }
                    }
                    break;
                case EActType.RANKING: {
                    if(ranking.Process(input, g))
                    {
                        ActType = EActType.TITLE;
                        title.IsDead = false;
                        barSelect.IsDead = false;
                        act = 0;
                        stageSelect.Reset();
                        stageSelect.IsDead = false;
                        message = null;
                        control = null;
                        ranking = null;
                    }
                }
                    break;
            }
            input.ClearSmaller();
        }

        private void Restart(Input input)
        {
            input.Clear();
            title = null;
            barSelect = null;
            stageSelect = null;

            title = new Title();
            barSelect = new BarSelect();
            stageSelect = new StageSelect();

            act = 0;
            stock = 0;

            switch (ActType)
            {
                case EActType.TITLE:
                    break;
                case EActType.BAR_SELECT:
                    barSelect.IsDead = false;
                    break;
                case EActType.STAGE_SELECT:
                    barSelect.IsDead = false;
                    stageSelect.IsDead = false;
                    control = null;
                    break;
            }

            ActType = EActType.TITLE;
        }

        public void ATMode(Input input)
        {
            if (input.AT)
            {
                if (c < 15)
                {
                    ++c;
                }
                else
                {
                    c = 0;

                    int r = rand.Next() % 3;

                    if (r == 0)
                        input.rB = true;
                    else if (r == 1)
                        input.lB = true;
                    else if (r == 2)
                        input.eB = true;
                }
            }
        }
    }
}
