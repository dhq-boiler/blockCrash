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
            DesktopKeyboard.SelectBarByInputKey(ref Bar, input, ref autoCount);

            if (input.eB && autoCount > 10)
            {
                barSelect.IsDead = true;
                input.eB = false;
                autoCount = 0;
            }
        }

        public void SelectStage(StageSelect stageSelect, ref int Stage, Input input, ref int autoCount)
        {
            DesktopKeyboard.SelectStageByInputKey(ref Stage, input, ref autoCount);

            if (input.eB && autoCount > 10)
            {
                stageSelect.IsDead = true;
                input.eB = false;
                autoCount = 0;
            }
        }

        public bool MoveBar(Bar bar, ref int AcceleratingCount, Input input)
        {
            if (PreviousX != bar.CenterX)
            {
                PreviousX = bar.CenterX;
                return true;
            }
            else
            {
                PreviousX = bar.CenterX;
                return false;
            }
        }

        public void ScrollRanking(Input input, ref int scoreY, ref bool scroll)
        { }
    }
}
