using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxLibDLL;

namespace libBlockCrashBridge
{
    class Ball
    {
        private int x;
        private int y;
        private int dx;
        private int dy;
        private int oldx;
        private int oldy;
        private int width;
        private int height;
        private bool endflag;
        private bool soundflag;
        private int[] gh;
        private bool penetrate;
        private int penecount;
        private bool sball;
        private int radius;
        private int t;
        private Input input;

        public const int MAX_SBALLCOUNT = 20;

        private void Draw()
        {
            if (penetrate)
                DX.DrawGraph(x - width / 2, y - height / 2, gh[1], 1);
            else if (sball)
                DX.DrawGraph(x - width / 2, y - height / 2, gh[2], 1);
            else
                DX.DrawGraph(x - width / 2, y - height / 2, gh[0], 1);
        }

        private void KeyGet()
        {
            if (input.eB) //決定ボタン
            {
                if (m_actcount == 0) //一番最初
                {
                    //最初の係数
                    dx = 3;
                    dy = -3;
                    m_actcount = 1;
                }
            }
        }

        private void Destroy()
        {
            throw new NotSupportedException();
        }

        private void Move()
        {
            //まず音はOFFにしとく
            soundflag = false;

            //移動量を加算
            x += dx;
            y += dy;

            //画面はみ出し処理
            if (x < width / 2) //左壁にあたった
            {
                x = width / 2;
                dx *= -1;
                soundflag = true;
            }

            if (x > Main.WIDTH - width / 2) //右壁にあたった
            {
                x = Main.WIDTH - width / 2;
                dx *= -1;
                soundflag = true;
            }

            if (y < height / 2 + 30) //上壁にあたった
            {
                y = height / 2 + 30;
                dy *= -1;
                soundflag = true;
            }

            if (y > Main.HEIGHT) //下にはみ出たらゲームオーバー
            {
                endflag = true;
            }
        }

        public Ball(Input input)
        {
            gh = new int[3];
            gh[0] = DX.LoadGraph("ball_a.png");
            gh[1] = DX.LoadGraph("ball2.bmp");
            gh[2] = DX.LoadGraph("ball3.bmp");

            DX.GetGraphSize(gh[0], out width, out height);

            //y座標は固定なのでここで設定
            y = 540 - height + 2;

            //最初は真ん中
            x = Main.WIDTH / 2 + 30;

            dx = dy = 0;

            radius = 60;

            m_actcount = 0;
            oldy = y;

            endflag = soundflag = penetrate = false;
            penecount = 0;

            sball = false;

            level = 1;
            t = 1;

            this.input = input;
        }

        public bool All()
        {
            if (m_actcount != 0 || sball)
            {
                Move();
            }

            //キー処理
            KeyGet();

            if (penecount > 0)
            {
                --penecount;
                if (penecount == 0)
                    penetrate = false;
            }

            Draw();

            return endflag;
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

        public void SetR(int r)
        {
            radius = r;
        }

        public void SetDX(int dx)
        {
            this.dx = dx;
            oldx = x;
        }

        public void SetX(int mx)
        {
            oldx = x; //回転用
            x = mx;
        }

        public void SetY(int my)
        {
            oldy = y; //回転用
            y = my;
        }

        public void SetDY(int dy)
        {
            this.dy = dy;
            oldx = x;
        }

        public int GetDX()
        {
            return dx;
        }

        public int GetDY()
        {
            return dy;
        }

        public bool GetSoundflag()
        {
            return soundflag;
        }

        public void PowerUp()
        {
            if (!sball) //小玉は貫通化しない
                penetrate = true;
            penecount = 150;
        }

        public void Increse(int mx, int my)
        {
            sball = true;
            Random rand = new Random(Environment.TickCount);
            int r = rand.Next() % 7;
            x = mx;
            y = my;
            dx += r - 3;
            dy += (6 - r) - 2;
            if (dy == 0)
                dy = -1;
        }

        public void spchange() //操作が進展しなくなったとき用
        {
            //擬似乱数
            Random rand = new Random(Environment.TickCount);
            int r = rand.Next() % 5;
            dx += r - 6;
            dy += (10 - r) - 6;
        }

        public bool isPene()
        {
            return penetrate;
        }

        public void Reset()
        {
            penetrate = false;

            //y座標は固定なのでここで設定
            y = 540 - height + 2;

            //最初は真ん中
            x = Main.WIDTH / 2 + 30;

            oldy = y;

            dx = 0;
            dy = 0;

            m_actcount = 0;

            endflag = false;
            radius = 1;
            level = 1;
        }

        public void LvUp(int inclv)
        {
            if (level < 20)
            {
                level += inclv;
                
                if (dx < 0)
                    --dx;
                else
                    ++dx;

                if (dy < 0)
                    --dy;
                else
                    ++dy;
            }
        }

        public int level;

        public int m_actcount;
    }
}
