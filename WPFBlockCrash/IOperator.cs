using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    interface IOperator
    {
        void SelectBar(BarSelect barSelect, ref int Bar, Input input, ref int autoCount);

        void SelectStage(StageSelect stageSelect, ref int Stage, Input input, ref int autoCount);

        bool MoveBar(Bar bar, ref int AcceleratingCount, Input input);

        void ScrollRanking(Input input, ref int scoreY, ref bool scroll);
    }
}
