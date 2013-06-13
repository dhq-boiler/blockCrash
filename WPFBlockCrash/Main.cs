using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    class Main
    {
        private StageSelect stageSelect;
        private Control control;
        private Message message;
        private BarSelect barSelect;
        private Title title;
        private int m_actcount;
        private int act;
        private int stock;
        private int c;
        private bool keycheck;
        private bool automode;
        private Input input;

        public Main(Input input)
        {
            this.input = input;
        }

        public bool All()
        {
            while (!input.IsFinished)
            {
                if (input.AT) //自動化状態
                {
                    ATMode();
                }

                if (automode && input.AT == false)
                {
                    Restart();
                }

                if (input.IsPushedKeys && keycheck)
                {
                    input.rB = input.RB;
                    input.lB = input.LB;
                    input.eB = input.EB;
                    input.RB = input.LB = input.EB = false;
                    keycheck = false;
                }

                switch (m_actcount)
                {
                    case 0:
                        {
                            if (title.All())
                                m_actcount = 1;
                            input.ClearSmaller();
                        }
                        break;
                    case 1:
                        {
                            if (barSelect.All())
                            {
                                stageSelect.SetValue(barSelect.mBar, 1, 0, 2);
                                m_actcount = 2;
                            }
                            input.ClearSmaller();
                        }
                        break;
                    case 2:
                        {
                            if (stageSelect.All())
                            {
                                m_actcount = 3;
                                stock = stageSelect.mStock;
                                control = new Control(input, stageSelect.mBar, stageSelect.mStage, stageSelect.mScore, stock);
                            }
                            input.ClearSmaller();
                        }
                        break;
                    case 3:
                        {
                            if (control.All())
                            {
                                stock = control.Stock;
                                if (stock > 1)
                                {
                                    if (act == 0)
                                    {
                                        message = new Message(1, 50);
                                        ++act;
                                    }

                                    if (message.All())
                                    {
                                        control.Reset();
                                        --stock;
                                        act = 0;
                                        message = null;
                                    }
                                }
                                else
                                {
                                    if (act == 0)
                                    {
                                        message = new Message(3, 200);
                                        ++act;
                                    }

                                    if (message.All())
                                    {
                                        m_actcount = 0;
                                        act = 0;
                                        stageSelect.Reset();
                                        stageSelect.SetFlag(false);
                                        message = null;
                                        control = null;
                                    }
                                }
                            }
                            else if (control.clear)
                            {
                                if (act == 0)
                                {
                                    message = new Message(2, 200);
                                    ++act;
                                }

                                if (message.All())
                                {
                                    if (input.AT)
                                    {
                                        m_actcount = 1;
                                        barSelect.SetFlag(false);
                                    }
                                    else
                                    {
                                        m_actcount = 2;
                                        stageSelect.SetValue(control.Bar, control.Stage, control.Score, control.Stock);
                                    }
                                    act = 0;
                                    stageSelect.SetFlag(false);
                                    message = null;
                                    control = null;
                                }
                            }
                            keycheck = true;
                            input.ClearSmaller();
                        }
                        break;
                }
            }

            stageSelect = null;
            barSelect = null;

            return false;
        }

        private void Restart()
        {
            input.Clear();
            title = null;
            barSelect = null;
            stageSelect = null;

            title = new Title(input);
            barSelect = new BarSelect(input);
            stageSelect = new StageSelect(input);

            act = 0;
            stock = 0;
            keycheck = true;
            automode = false;

            switch (m_actcount)
            {
                case 0 :
                    break;
                case 1:
                    barSelect.SetFlag(false);
                    break;
                case 2:
                    barSelect.SetFlag(false);
                    stageSelect.SetFlag(false);
                    control = null;
                    break;
            }

            m_actcount = 0;
        }

        private void ATMode()
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

                    Random rand = new Random(Environment.TickCount);

                    int r = rand.Next() % 3;

                    if (r == 0)
                        input.RB = true;
                    else if (r == 1)
                        input.LB = true;
                    else if (r == 2)
                        input.EB = true;
                }
            }
        }
    }
}
