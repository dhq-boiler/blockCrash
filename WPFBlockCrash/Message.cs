using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    public enum EMessageType
    {
        UNKNOWN,
        FAILED,
        CLEAR,
        GAMEOVER
    }

    class Message
    {
        private EMessageType MessageType { get; set; }
        private int count;
        private string message;
        private readonly string message2 = "残機に応じてスコアにボーナスが乗ります!!";
        private DisplayInfo dInfo;
        private DateTime? BeginDisplayTime;

        private readonly Font font = new Font("Consolas", 20);

        public bool IsDead { get; set; }


        public Message(EMessageType MessageType, int count, DisplayInfo dInfo)
        {
            this.dInfo = dInfo;
            this.MessageType = MessageType;
            this.count = count;

            IsDead = false;

            switch (MessageType)
            {
                case EMessageType.FAILED:
                    message = "BALL FAILED!!";
                    break;
                case EMessageType.CLEAR:
                    message = "CLEAR!!";
                    break;
                case EMessageType.GAMEOVER:
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
                //半透明黒で画面を暗転させる
                g.DrawRectangle(new System.Drawing.Pen(DrawUtil.BrushRGB(128, 30, 30, 30)), 0, 0, dInfo.Width, dInfo.Height);

                //メインメッセージ
                g.DrawString(message, font, DrawUtil.BrushRGB(255, 255, 255), 300, 300);

                if (MessageType == EMessageType.CLEAR)
                    g.DrawString(message2, font, DrawUtil.BrushRGB(255, 255, 255), 150, 350);

                --count;
            }
            else
                IsDead = true;
        }

        private void KeyGet(Input input)
        {
            if (BeginDisplayTime == null)
                BeginDisplayTime = DateTime.Now;
            else if ((DateTime.Now - BeginDisplayTime.Value).TotalSeconds >= 1)
                IsDead = true;
            IsDead = false;
        }
    }
}
