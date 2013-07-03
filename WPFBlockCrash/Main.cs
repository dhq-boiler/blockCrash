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
        private WPFBlockCrash.BlockCrashView.EOperatingType OperatingType;
        private int AutoModeControl;
        private DisplayInfo dInfo;
        private UserChoice userChoice;
        private TakeOver takeOver;
        public static readonly string ResourceDirectory = Directory.GetCurrentDirectory() + "\\res\\";
        public static readonly Random rand = new Random(Environment.TickCount);
        
        public Main(DisplayInfo dInfo, WPFBlockCrash.BlockCrashView.EOperatingType OperatingType)
        {
            this.dInfo = dInfo;
            this.OperatingType = OperatingType;

            switch (OperatingType)
            {
                case BlockCrashView.EOperatingType.DESKTOP_KEYBOARD:
                    CurrentState = new Title(dInfo, new DesktopKeyboard());
                    break;
                case BlockCrashView.EOperatingType.VIRTOS_SLIDER:
                    CurrentState = new Title(dInfo, new VIRTOSSlider());
                    break;
            }
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

            input.ClearSmaller();
        }

        private void Restart(Input input)
        {
            input.Clear();

            switch (OperatingType)
            {
                case BlockCrashView.EOperatingType.DESKTOP_KEYBOARD:
                    CurrentState = new Title(dInfo, new DesktopKeyboard());
                    break;
                case BlockCrashView.EOperatingType.VIRTOS_SLIDER:
                    CurrentState = new Title(dInfo, new VIRTOSSlider());
                    break;
            }
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
