using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxLibDLL;

namespace libBlockCrashBridge
{
    class Title
    {
        private bool endflag;
        private int titlegh;
        private bool selectflag;
        private bool decisionflag;
        private int sh;
        private int dh;
        private Input input;

        private void Draw()
        {
            DX.DrawGraph(0, 0, titlegh, 1); //タイトル表示
        }

        private void KeyGet()
        {
            if (input.rB || input.lB || input.eB) //ボタンon
                endflag = true;
        }

        public bool All()
        {
            //キー処理
            KeyGet();

            //描画処理
            Draw();

            return endflag;
        }

        public Title(Input input)
        {
            this.input = input;
            titlegh = DX.LoadGraph("title.png"); // タイトル

            selectflag = false;
            decisionflag = false;

            endflag = false;

            //音声ファイル読み込み。
            sh = DX.LoadSoundMem("bound.wav");
            dh = DX.LoadSoundMem("demolish.wav");
        }

        public void SetFlag(bool flag)
        {
            endflag = flag;
        }

        public bool GetFlag()
        {
            return endflag;
        }
    }
}
