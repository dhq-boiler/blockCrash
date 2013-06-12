using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxLibDLL;

namespace libBlockCrashBridge
{
    class Message
    {
        private int ct;
        private bool endflag;
        private string mes;
        private Input input;

        public Message(Input input, int pattern, int count)
        {
            this.input = input;
            ct = count;
            endflag = false;
            switch (pattern)
            {
                case 1: mes = "BALL FAILED!!";
                    break;
                case 2: mes = "CLEAR!!";
                    break;
                case 3: mes = "GAME OVER!!";
                    break;
            }
        }
        
        private void Draw()
        {
            if (ct > 0)
            {
                DX.SetDrawBlendMode(DX.DX_BLENDMODE_ALPHA, 128);
                DX.DrawBox(0, 0, Main.WIDTH, Main.HEIGHT, Color.RGB(30, 30, 30), 1);
                // 描画する文字列のサイズを設定
                DX.SetFontSize(32);
                // 文字列の描画
                DX.SetDrawBlendMode(DX.DX_BLENDMODE_NOBLEND, 0);
                DX.DrawString(250, 300, mes, Color.RGB(255, 255, 255));
                DX.SetFontSize(16);
                --ct;
            }
            else
                endflag = true;
        }

        private void KeyGet()
        {
            if (input.key256[Input.KEY_INPUT_A] == 1)
            {
                //演出スキップボタン
                endflag = true;
            }
        }

        public bool All()
        {
            //キー処理
            KeyGet();

            //描画処理
            Draw();

            return endflag;
        }
    }
}
