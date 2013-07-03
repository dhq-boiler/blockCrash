using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    class AutomaticOperator : IOperator
    {
        int PreviousX;

        public void SelectBar(BarSelect barSelect, ref int Bar, Input input, ref int autoCount)
        {
            if (input.eB && autoCount > 10)
            {
                barSelect.IsDead = true;
                input.eB = false;
                autoCount = 0;
            }
        }

        public void SelectStage(StageSelect stageSelect, ref int Stage, Input input, ref int autoCount)
        {
            if (input.eB && autoCount > 10)
            {
                stageSelect.IsDead = true;
                input.eB = false;
                autoCount = 0;
            }
        }

        public bool MoveBar(Bar bar, ref int AcceleratingCount, Input input)
        {
            if (PreviousX != bar.X)
            {
                PreviousX = bar.X;
                return true;
            }
            else
            {
                PreviousX = bar.X;
                return false;
            }
        }

        public void ScrollRanking(Input input, ref int scoreY, ref bool scroll)
        { }
    }
}
