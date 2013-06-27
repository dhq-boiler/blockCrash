using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPFBlockCrash
{
    class Message
    {
        private int pattern;
        private int count;
        private string message;
        private string message2;
        private DisplayInfo dInfo;
        private DateTime? BeginDisplayTime;

        private readonly Font font = new Font("Consolas", 20);

        public bool IsDead { get; set; }

        public Message(int pattern, int count, DisplayInfo dInfo)
        {
            this.dInfo = dInfo;
            this.pattern = pattern;
            this.count = count;

            IsDead = false;

            switch (pattern)
            {
                case 1:
                    message = "BALL FAILED!!";
                    break;
                case 2:
                    message = "CLEAR!!";
                    message2 = "残機に応じてスコアにボーナスが乗ります!!";
                    break;
                case 3:
                    message = "GAME OVER!!";
                    break;
            }
        }

        internal bool Process(Input input, Graphics g)
        {
            //キー処理
            KeyGet(input);

            //描画処理
            Draw(g);

            return IsDead;
        }

        private void Draw(Graphics g)
        {
            if (count > 0)
            {
                //float opacity = 128f / byte.MaxValue;
                //dc.PushOpacity(128d / byte.MaxValue);
                //DrawUtil.DrawBox(dc, 0, 0, dInfo.Width, dInfo.Height, RGB(30, 30, 30));
                g.DrawRectangle(new System.Drawing.Pen(ARGB(128, 30, 30, 30)), 0, 0, dInfo.Width, dInfo.Height);
                //dc.Pop();
                //DrawUtil.DrawString(dc, 300, 300, message, RGB(255, 255, 255), 32);
                g.DrawString(message, font, RGB(255, 255, 255), 300, 300);
                if (pattern == 2) // クリアなら
                    //DrawUtil.DrawString(dc, 150, 350, message2, RGB(255, 255, 255), 32);
                    g.DrawString(message2, font, RGB(255, 255, 255), 150, 350);
                --count;
            }
            else
                IsDead = true;
        }

        private System.Drawing.Color ARGB(byte a, byte r, byte g, byte b)
        {
            return System.Drawing.Color.FromArgb(a, r, g, b);
        }

        private System.Drawing.Brush RGB(byte r, byte g, byte b)
        {
            return new SolidBrush(System.Drawing.Color.FromArgb(r, g, b));
        }

        private void KeyGet(Input input)
        {
            //if (input.key256[Input.KEY_INPUT_SPACE] == 1)
            if (BeginDisplayTime == null)
                BeginDisplayTime = DateTime.Now;
            else if ((DateTime.Now - BeginDisplayTime.Value).TotalSeconds >= 1)
                IsDead = true;
            IsDead = false;
        }
    }
}
