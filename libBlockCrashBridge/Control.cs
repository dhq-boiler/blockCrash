using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libBlockCrashBridge
{
    class Control
    {
        private Bar bar;
        private Ball ball;
        private Ball[] sball;
        private Block[] block;
        private int bdx;
        private int bdy;
        private int blx;
        private int bly;
        private int bkx;
        private int bky;
        private int bdwidth;
        private int bdheight;
        private int blwidth;
        private int blheight;
        private int bkwidth;
        private int bkheight;
        private int exwidth;
        private bool boundflag;
        private bool demolishflag;
        private int bh;
        private int dh;
        private int sballcount;
        private int mlevel;
        private int mscore;
        private int mstock;
        private int gh;
        private int act;
        private int sumblock;
        private int mstage;
        private int accel;
        private int barnum;
        private int ballspup;
        private int vspeed;

        public Control(int mbar, int stage, int score, int stock)
        {
            throw new NotImplementedException();
        }

        private void HitCheckBallAndBar(Ball ball)
        {
            throw new NotImplementedException();
        }

        private void HitCheckBallAndBlock(Ball ball)
        {
            throw new NotImplementedException();
        }

        private void SoundPlay()
        {
            throw new NotImplementedException();
        }

        private void ItemEffect(ItemType it, int bx, int by)
        {
            throw new NotImplementedException();
        }

        public bool All()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public int GetStage()
        {
            throw new NotImplementedException();
        }

        public int GetScore()
        {
            throw new NotImplementedException();
        }

        public int GetStock()
        {
            throw new NotImplementedException();
        }

        public int GetBar()
        {
            throw new NotImplementedException();
        }

        public bool clear;
    }
}
