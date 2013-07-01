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
        private SoundPlayer sh;
        private SoundPlayer dh;

        private DisplayInfo dInfo;
        
        public Title(DisplayInfo dInfo)
        {
            titleGh = new Bitmap(Main.ResourceDirectory + "title.png");
            this.dInfo = dInfo;

            selectSoundFlag = false;
            decisionSoundFlag = false;
            IsDead = false;
            atcount = 0;

            sh = new SoundPlayer(Main.ResourceDirectory + "bound.wav");
            dh = new SoundPlayer(Main.ResourceDirectory + "demolish.wav");
        }

        public ProcessResult Process(Input input, Graphics g, UserChoice uc, TakeOver takeOver)
        {
            //キー処理
            KeyGet(input);

            //描画処理
            Draw(g);

            if (IsDead)
                return new ProcessResult() { IsDead = IsDead, NextState = new BarSelect(dInfo) };
            else
                return new ProcessResult() { IsDead = IsDead, NextState = this };
        }

        private void KeyGet(Input input)
        {
            if (input.barx == 750)
            {
                input.AT = true;
            }

            if (input.rB || input.eB) //いずれかのボタンが押されている
            {
                IsDead = true;
            }
            if (input.lB) //左ボタンがおしっぱ
            {
                ++atcount;
                if (atcount > 100)
                {
                    input.AT = true;
                }
            }
        }

        private void Draw(Graphics g)
        {
            //タイトル表示
            g.DrawImage(titleGh, 0, 0);
        }
    }
}
