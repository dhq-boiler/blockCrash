using System;
using System.Collections.Generic;
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
        private DisplayInfo dInfo;
        private DateTime? BeginDisplayTime;

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
                    break;
                case 3:
                    message = "GAME OVER!!";
                    break;
            }
        }

        internal bool Process(Input input, DrawingContext dc)
        {
            //キー処理
            KeyGet(input);

            //描画処理
            Draw(dc);

            return IsDead;
        }

        private void Draw(DrawingContext dc)
        {
            if (count > 0)
            {
                dc.PushOpacity(128d / byte.MaxValue);
                DrawUtil.DrawBox(dc, 0, 0, dInfo.Width, dInfo.Height, RGB(30, 30, 30));
                dc.Pop();
                DrawUtil.DrawString(dc, 250, 300, message, RGB(255, 255, 255), 32);
                --count;
            }
            else
                IsDead = true;
        }

        private Color RGB(byte r, byte g, byte b)
        {
            return Color.FromRgb(r, g, b);
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
