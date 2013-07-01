﻿using System;
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

        public static readonly double RunningSpeedFactor = 1.5;

        //private StageSelect stageSelect;
        //private Control control;
        //private Message message;
        //private BarSelect barSelect;
        //private Title title;
        //private Ranking ranking;

        private IInputable CurrentState;
        //private UserChoice userChoise;

        //private EActType ActType;

        //private int act;
        //private int stock;
        private int AutoModeControl;
        private DisplayInfo dInfo;
        private UserChoice userChoice;
        private TakeOver takeOver;
        public static readonly string ResourceDirectory = Directory.GetCurrentDirectory() + "\\res\\";
        public static readonly Random rand = new Random(Environment.TickCount);
        
        public Main(DisplayInfo dInfo)
        {
            this.dInfo = dInfo;

            CurrentState = new Title(dInfo);
            userChoice = new UserChoice();
            takeOver = new TakeOver()
            {
                DisplayInfo = dInfo,
                Score = 0,
                Stock = 2
            };
            //title = new Title();
            //barSelect = new BarSelect();
            //stageSelect = new StageSelect();
            //ActType = EActType.TITLE;
            //act = 0;
            //stock = 0;
            AutoModeControl = 0;
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

            ProcessResult r = CurrentState.Process(input, g, userChoice, takeOver);
            CurrentState = r.NextState;

            //switch (ActType)
            //{
            //    case EActType.TITLE:
            //        {
            //            if (title.Process(input, g))
            //                ActType = EActType.BAR_SELECT;
            //        }
            //        break;
            //    case EActType.BAR_SELECT:
            //        {
            //            if (barSelect.Process(input, g))
            //            {
            //                stageSelect.SetValue(barSelect.mBar, 0, 0, 2);
            //                ActType = EActType.STAGE_SELECT;
            //            }
            //        }
            //        break;
            //    case EActType.STAGE_SELECT:
            //        {
            //            if (stageSelect.Process(input, g))
            //            {
            //                ActType = EActType.CONTROL;
            //                stock = stageSelect.Stock;
            //                control = new Control(stageSelect.Bar, stageSelect.Stage, stageSelect.Score, stock, dInfo, input);
            //            }
            //        }
            //        break;
            //    case EActType.CONTROL:
            //        {
            //            if (control.Process(input, g))
            //            {
            //                stock = control.Stock;
            //                if (stock > 1)
            //                {
            //                    if (act == 0)
            //                    {
            //                        message = new Message(EMessageType.FAILED, 50, dInfo);
            //                        ++act;
            //                    }

            //                    if (message.Process(input, g))
            //                    {
            //                        control.Reset(); // 残機を減らしゲームを続行
            //                        --stock;
            //                        act = 0;
            //                        message = null;
            //                    }
            //                }
            //                else
            //                {
            //                    if (act == 0)
            //                    {
            //                        message = new Message(EMessageType.GAMEOVER, 120, dInfo);
            //                        ++act;
            //                    }

            //                    if (message.Process(input, g))
            //                    {
            //                        ActType = EActType.RANKING;
            //                        ranking = new Ranking(control.Score,control.Bar, dInfo);
            //                    }
            //                }
            //            }
            //            else if (control.clear)
            //            {
            //                if (act == 0)
            //                {
            //                    message = new Message(EMessageType.CLEAR, 200, dInfo);
            //                    ++act;
            //                }

            //                if (message.Process(input, g))
            //                {
            //                    ActType = EActType.RANKING;
            //                    ranking = new Ranking(control.Score, control.Bar, dInfo);
            //                }
            //            }
            //        }
            //        break;
            //    case EActType.RANKING: {
            //        if(ranking.Process(input, g))
            //        {
            //            ActType = EActType.TITLE;
            //            title.IsDead = false;
            //            barSelect.IsDead = false;
            //            act = 0;
            //            stageSelect.Reset();
            //            stageSelect.IsDead = false;
            //            message = null;
            //            control = null;
            //            ranking = null;
            //        }
            //    }
            //        break;
            //}
            input.ClearSmaller();
        }

        private void Restart(Input input)
        {
            input.Clear();
            //title = null;
            //barSelect = null;
            //stageSelect = null;

            //title = new Title(dInfo);
            //barSelect = new BarSelect();
            //stageSelect = new StageSelect();

            //act = 0;
            //stock = 0;

            //switch (ActType)
            //{
            //    case EActType.TITLE:
            //        break;
            //    case EActType.BAR_SELECT:
            //        barSelect.IsDead = false;
            //        break;
            //    case EActType.STAGE_SELECT:
            //        barSelect.IsDead = false;
            //        stageSelect.IsDead = false;
            //        control = null;
            //        break;
            //}

            //ActType = EActType.TITLE;

            CurrentState = new Title(dInfo);
        }

        public void ATMode(Input input)
        {
            if (input.AT)
            {
                if (AutoModeControl < 15)
                {
                    ++AutoModeControl;
                }
                else
                {
                    AutoModeControl = 0;

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
