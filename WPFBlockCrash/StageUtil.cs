using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    static class StageUtil
    {
        public static void CommonBlockProcess(Input input, Graphics g, UserChoice uc, TakeOver takeOver,  Block[] block, ref int ballDeadCount, int sumblock)
        {
            for (int i = 0; i < sumblock; ++i)
            {
                if (block[i].IsDead)
                    ++ballDeadCount;

                if (i % 4 == 0)
                    block[i].Process(input, g, uc, takeOver);
                else if (i % 4 == 1)
                    block[i].Process(input, g, uc, takeOver);
                else if (i % 4 == 2)
                    block[i].Process(input, g, uc, takeOver);
                else
                    block[i].Process(input, g, uc, takeOver);
            }
        }
    }
}
