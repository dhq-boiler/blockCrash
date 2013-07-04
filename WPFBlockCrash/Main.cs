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
        public static readonly bool PenetrationEnables = false;
        public static readonly bool CatchBallEnables = false;
        public static readonly string ResourceDirectory = Directory.GetCurrentDirectory() + "\\res\\";
        public static readonly Random rand = new Random(Environment.TickCount);
        public static Main MainInstance = null;

        private IInputable CurrentState;
        private WPFBlockCrash.BlockCrashView.EOperatingType OperatingType;
        private int AutoModeControl;
        private DisplayInfo dInfo;
        private UserChoice userChoice;
        private TakeOver takeOver;
        private WPFBlockCrash.BlockCrashView.EOperatingType OldOperatingType;
        private Title title;
        private bool ResultIgnore;
        
        public Main(DisplayInfo dInfo, WPFBlockCrash.BlockCrashView.EOperatingType OperatingType)
        {
            MainInstance = this;
            this.dInfo = dInfo;
            this.OperatingType = OperatingType;

            Reconstruct(dInfo, OperatingType);
            userChoice = new UserChoice();
            takeOver = new TakeOver()
            {
                DisplayInfo = dInfo,
                Score = 0,
                Stock = 2
            };
            AutoModeControl = 0;
        }

        private void Reconstruct(DisplayInfo dInfo, WPFBlockCrash.BlockCrashView.EOperatingType OperatingType)
        {
            switch (OperatingType)
            {
                case BlockCrashView.EOperatingType.DESKTOP_KEYBOARD:
                    CurrentState = title = new Title(this, dInfo, new DesktopKeyboard());
                    break;
                case BlockCrashView.EOperatingType.VIRTOS_SLIDER:
                    CurrentState = title = new Title(this, dInfo, new VIRTOSSlider());
                    break;
                case BlockCrashView.EOperatingType.AUTO:
                    CurrentState = title = new Title(this, dInfo, new AutomaticOperator());
                    break;
                default:
                    throw new InvalidOperationException("EOperatingType is UNKNOWN.");
            }

            ResultIgnore = true;
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
                    //title.SwapOperatingMode();
                    //Reconstruct(dInfo, OperatingType);
                    SwapOperatingMode();
                    Restart(input);
                }
            }

            ProcessResult r = CurrentState.Process(input, g, userChoice, takeOver);
            if (!ResultIgnore)
                CurrentState = r.NextState;
            else
            {
                CurrentState = title;
                ResultIgnore = false;
            }

            input.ClearSmaller();
        }

        public void Restart(Input input)
        {
            input.Clear();

            Reconstruct(dInfo, OperatingType);
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

        internal void SwapOperatingMode()
        {
            if (OldOperatingType == BlockCrashView.EOperatingType.UNKNOWN)
                OldOperatingType = BlockCrashView.EOperatingType.AUTO;

            WPFBlockCrash.BlockCrashView.EOperatingType temp = OperatingType;
            OperatingType = OldOperatingType;
            OldOperatingType = temp;
        }
    }
}
