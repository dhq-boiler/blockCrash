using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WPFBlockCrash
{
    class Title
    {
        public Title()
        {
            try
            {
                titleGh = new BitmapImage(new Uri(Main.ResourceDirectory, "title.png"));
            }
            catch (Exception e)
            {

            }

            selectSoundFlag = false;
            decisionSoundFlag = false;
            IsDead = false;
            atcount = 0;

            sh = new SoundPlayer(Main.ResourceDirectory + "bound.wav");
            dh = new SoundPlayer(Main.ResourceDirectory + "demolish.wav");
        }

        public bool Process(Input input, DrawingContext dc)
        {
            //キー処理
            KeyGet(input);

            //描画処理
            Draw(dc);

            return IsDead;
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

        private void Draw(DrawingContext dc)
        {
            //タイトル表示
            //dc.DrawImage(titleGh, new Rect(0, 0, titleGh.Width, titleGh.Height));
            DrawUtil.DrawGraph(dc, 0, 0, titleGh);
        }

        private ImageSource titleGh;
        public bool IsDead { get; set; }
        public bool selectSoundFlag { get; private set; }
        public bool decisionSoundFlag { get; private set; }
        public int atcount { get; private set; }
        private SoundPlayer sh;
        private SoundPlayer dh;
    }
}
