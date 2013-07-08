using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFBlockCrash
{
    class Title : IInputable
    {
        private Image titleGh;
        public bool IsDead { get; set; }
        public bool selectSoundFlag { get; private set; }
        public bool decisionSoundFlag { get; private set; }
        public int atcount { get; private set; }

        private Main main;
        private DisplayInfo dInfo;
        private IOperator Operator;
        //private IOperator OtherOperator;
        
        public Title(Main main, DisplayInfo dInfo, IOperator Operator)
        {
            this.main = main;
            this.dInfo = dInfo;
            this.Operator = Operator;

            titleGh = new Bitmap(Main.ResourceDirectory + "title.png");

            //OtherOperator = new AutomaticOperator();

            selectSoundFlag = false;
            decisionSoundFlag = false;
            IsDead = false;
            atcount = 0;
        }

        public ProcessResult Process(Input input, Graphics g, UserChoice uc, TakeOver takeOver)
        {
            //キー処理
            KeyGet(input);

            //描画処理
            Draw(g);

            if (IsDead)
                return new ProcessResult() { IsDead = IsDead, NextState = new BarSelect(dInfo, Operator) };
            else
                return new ProcessResult() { IsDead = IsDead, NextState = this };
        }

        private void KeyGet(Input input)
        {
            if (!input.AT && input.barx == 750)
            {
                input.AT = true;
                //main.SwapOperatingMode();
                //main.Restart(input);
                //ChangeMode();
                //SwapOperatingMode();
                main.SwapOperatingMode();
                main.Restart(input);
            }

            if (input.rB || input.eB) //いずれかのボタンが押されている
            {
                IsDead = true;
            }

            if (!input.AT && input.lB) //左ボタンがおしっぱ
            {
                ++atcount;
                if (atcount > 100)
                {
                    input.AT = true;
                    //main.SwapOperatingMode();
                    //main.Restart(input);
                }
            }
        }

        //public void SwapOperatingMode()
        //{
        //    IOperator temp = Operator;

        //    Operator = OtherOperator;

        //    OtherOperator = temp;
        //}

        //private void ChangeMode(WPFBlockCrash.BlockCrashView.EOperatingType OperatingType)
        //{
        //    switch (OperatingType)
        //    {
        //        case BlockCrashView.EOperatingType.DESKTOP_KEYBOARD:
        //            Operator = new DesktopKeyboard();
        //            break;
        //        case BlockCrashView.EOperatingType.VIRTOS_SLIDER:
        //            Operator = new VIRTOSSlider();
        //            break;
        //        case BlockCrashView.EOperatingType.AUTO:
        //            Operator = new AutomaticOperator();
        //            break;
        //        default:
        //            throw new InvalidOperationException("EOperatingType is UNKNOWN.");
        //    }
        //}

        private void Draw(Graphics g)
        {
            //タイトル表示
            g.DrawImage(titleGh, 0, 0);
        }
    }
}
