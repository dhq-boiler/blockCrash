using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxLibDLL;

namespace libBlockCrashBridge
{
    class Bar
    {
        private int x;
        private int y;
        private int width;
        private int height;
        private bool endflag;
        private int[] gh;
        private int ex;
        private bool end;
        private int accel;
        private int mbar;
        private Input input;

        private void Draw()
        {
            DX.DrawExtendGraph(x - width * ex / 4, y - height / 2,
                x + width * ex / 4, y + height / 2, gh[mbar], 1);
        }

        private bool KeyGet()
        {
            bool on = false;

            if (input.barx != 0) //バーの移動
            {
                x = input.barx;
                on = true;
            }

            if (input.key256[Input.KEY_INPUT_LEFT] == 1)
            {
                //左に移動
                x -= Main.SPEED;
                accel = -1;
                on = true;
            }

            if (input.key256[Input.KEY_INPUT_ESCAPE] == 1)
            {
                //エスケープキーが押されていれば終了フラグをtrueにする
                endflag = true;
            }
            
            //画面のはみ出し処理
            if (x < width * ex / 4)
                x = width * ex / 4;

            if (x > Main.WIDTH - width * ex / 4)
                x = Main.WIDTH - width * ex / 4;

            mx = x;
            return on;
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public Bar(Input input, int barnum)
        {
            this.input = input;

            gh = new int[3];
            gh[0] = DX.LoadGraph("bar.bmp"); //バー１
            gh[1] = DX.LoadGraph("barsecond.bmp"); //バー２
            gh[2] = DX.LoadGraph("barthird.bmp"); //バー3

            mbar = barnum - 1;

            DX.GetGraphSize(gh[mbar], out width, out height);

            //y座標は固定なのでここで設定
            y = 540;

            //最初は真ん中
            x = Main.WIDTH / 2;

            //拡大率の初期化
            ex = 2;

            //終了フラグは偽にしとく
            endflag = false;

            end = false;
        }

        public bool All()
        {
            if (!end)
            {
                //キー処理
                if (!KeyGet())
                    accel = 0;
            }

            //描画処理
            Draw();

            //終了フラグを返す
            return endflag;
        }

        public void SetX(int vx)
        {
            x = vx;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public int GetAcceleration()
        {
            return accel;
        }

        public void SetFlag(bool flag)
        {
            end = flag;
        }

        public void ExtendWidth()
        {
            ++ex;
        }

        public void Reset()
        {
            ex = 2;
        }

        public int mx;
    }
}
