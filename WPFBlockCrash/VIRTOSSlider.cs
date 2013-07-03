using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    class VIRTOSSlider : IOperator
    {
        public void SelectBar(ref int BarType, Input input, ref int autoCount)
        {
            if (input.barx < 700d / 3d * 1d && input.barx >= 50)
            {
                BarType = 1;
            }
            else if (input.barx >= 700d / 3d * 1d && input.barx < 700d / 3d * 2d)
            {
                BarType = 2;
            }
            else if (input.barx >= 700d / 3d * 2d && input.barx < 700d)
            {
                BarType = 3;
            }
        }


        public void SelectStage(ref int Stage, Input input, ref int autoCount)
        {
            if (input.barx >= 50 && input.barx < 700d / 5d * 1d)
            {
                Stage = 1;
            }
            else if (input.barx >= 700d / 5d * 1d && input.barx < 700d / 5d * 2d)
            {
                Stage = 2;
            }
            else if (input.barx >= 700d / 5d * 2d && input.barx < 700d / 5d * 3d)
            {
                Stage = 3;
            }
            else if (input.barx >= 700d / 5d * 3d && input.barx < 700d / 5d * 4d)
            {
                Stage = 4;
            }
            else if (input.barx >= 700d / 5d * 4d && input.barx < 700d)
            {
                Stage = 5;
            }
        }


        public bool MoveBar(Bar bar, ref int AcceleratingCount, Input input)
        {
            bool IsPushedAnyKey = false;

            if (!input.AT && input.barx != 0)
            {
                bar.IsMove = true;
                bar.X = input.barx;
                IsPushedAnyKey = true;
            }

            return IsPushedAnyKey;
        }


        public void ScrollRanking(Input input, ref int scoreY, ref bool scroll)
        {
            throw new NotImplementedException();
        }
    }
}
