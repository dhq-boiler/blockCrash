using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxLibDLL;

namespace libBlockCrashBridge
{
    public class Game
    {
        private int vx;
        private int endflag;
        private Main main;
        private Input input;

        public Game()
        {
            main = new Main(input);
        }

        public bool GameStart()
        {
            return main.All();
        }

        public void RButton()
        {
            input.RB = true;
            input.Key = true;
        }

        public void LButton()
        {
            input.LB = true;
            input.Key = true;
        }

        public void BarMove(int vx)
        {
            input.barx = vx;
        }

        public void EnterButton()
        {
            input.EB = true;
            input.Key = true;
        }

        public void Auto(bool on)
        {
            input.AT = on;
        }

        public void KeyEnd()
        {
            input.Key = false;
        }
    }
}
