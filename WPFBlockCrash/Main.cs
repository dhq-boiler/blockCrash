using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPFBlockCrash
{
    class Main
    {
        enum EActType
        {
            TITLE,
            BAR_SELECT,
            STAGE_SELECT,
            CONTROL
        }

        private StageSelect stageSelect;
        private Control control;
        private Message message;
        private BarSelect barSelect;
        private Title title;

        //private int m_actcount;
        private EActType ActType;

        private int act;
        private int stock;
        private int c;
        private bool keycheck;
        private bool automode;
        private DisplayInfo dInfo;
        public static readonly Uri ResourceDirectory = new Uri(Directory.GetCurrentDirectory() + "\\res\\");
        public static readonly Random rand = new Random(Environment.TickCount);
        
        public Main(DisplayInfo dInfo)
        {
            this.dInfo = dInfo;

            title = new Title();
            barSelect = new BarSelect();
            stageSelect = new StageSelect();
            //m_actcount = 0;
            ActType = EActType.TITLE;
            act = 0;
            stock = 0;
            keycheck = true;
            automode = false;
            c = 0;
        }

        public void ProcessLoop(Input input, DrawingContext dc)
        {
            //using (DrawingContext dc = dg.Open())
            //{

            DrawUtil.DrawBox(dc, 0, 0, 800, 600, Color.FromRgb(0, 0, 0), 1, Color.FromRgb(0, 0, 0));

            if (input.IsPushedKeys)
            {
                input.rB = input.RB.Output;
                input.lB = input.LB.Output;
                input.eB = input.EB.Output;
                //input.rB = input.RB;
                //input.lB = input.LB;
                //input.eB = input.EB;
                //input.RB = input.LB = input.EB = false;
            }

            if (input.AT) //自動化状態
            {
                ATMode(input);

                if (input.barx == 50)
                {
                    input.AT = false;
                    Restart(input);
                }
            }

            //if (automode && input.AT == false)
            //{
                //Restart(input);
            //}

            //switch (m_actcount)
            switch (ActType)
            {
                //case 0:
                case EActType.TITLE:
                    {
                        if (title.Process(input, dc))
                            //m_actcount = 1;
                            ActType = EActType.BAR_SELECT;
                        //input.ClearSmaller();
                    }
                    break;
                //case 1:
                case EActType.BAR_SELECT:
                    {
                        if (barSelect.Process(input, dc))
                        {
                            stageSelect.SetValue(barSelect.mBar, 0, 0, 2);
                            //m_actcount = 2;
                            ActType = EActType.STAGE_SELECT;
                        }
                        //input.ClearSmaller();
                    }
                    break;
                //case 2:
                case EActType.STAGE_SELECT:
                    {
                        if (stageSelect.Process(input, dc))
                        {
                            //m_actcount = 3;
                            ActType = EActType.CONTROL;
                            stock = stageSelect.Stock;
                            control = new Control(stageSelect.Bar, stageSelect.Stage, stageSelect.Score, stock, dInfo);
                        }
                        //input.ClearSmaller();
                    }
                    break;
                //case 3:
                case EActType.CONTROL:
                    {
                        if (control.Process(input, dc))
                        {
                            stock = control.Stock;
                            if (stock > 1)
                            {
                                if (act == 0)
                                {
                                    message = new Message(1, 50, dInfo);
                                    ++act;
                                }

                                if (message.Process(input, dc))
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
                                    message = new Message(3, 200, dInfo);
                                    ++act;
                                }

                                if (message.Process(input, dc))
                                {
                                    //m_actcount = 0;
                                    ActType = EActType.TITLE;
                                    act = 0;
                                    title.IsDead = false;
                                    
                                    barSelect.IsDead = false;

                                    stageSelect.Reset();
                                    //stageSelect.SetFlag(false);
                                    stageSelect.IsDead = false;
                                    message = null;
                                    control = null;
                                }
                            }
                        }
                        else if (control.clear)
                        {
                            if (act == 0)
                            {
                                message = new Message(2, 200, dInfo);
                                ++act;
                            }

                            if (message.Process(input, dc))
                            {
                                //if (input.AT) // 疲れるからタイトルへ
                               // {
                                    //m_actcount = 1;
                                ActType = EActType.TITLE;
                                    //barSelect.SetFlag(false);
                                title.IsDead = false;
                                    barSelect.IsDead = false;
                                ///}
                                //else
                               // {
                                //    m_actcount = 2;
                                //    stageSelect.SetValue(control.Bar, control.Stage, control.Score, control.Stock);
                                //}
                                act = 0;
                                //stageSelect.SetFlag(false);
                                stageSelect.IsDead = false;
                                message = null;
                                control = null;
                            }
                        }
                        //keycheck = true;
                        //input.ClearSmaller();
                    }
                    break;
            }
            input.ClearSmaller();
            //input.ClearArray();
            //}
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
            keycheck = true;
            automode = false;

            //switch (m_actcount)
            switch (ActType)
            {
                //case 0 :
                case EActType.TITLE:
                    break;
                //case 1:
                case EActType.BAR_SELECT:
                    //barSelect.SetFlag(false);
                    barSelect.IsDead = false;
                    break;
                //case 2:
                case EActType.STAGE_SELECT:
                    //barSelect.SetFlag(false);
                    barSelect.IsDead = false;
                    //stageSelect.SetFlag(false);
                    stageSelect.IsDead = false;
                    control = null;
                    break;
            }

            //m_actcount = 0;
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

                    //Random rand = new Random(Environment.TickCount);

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
