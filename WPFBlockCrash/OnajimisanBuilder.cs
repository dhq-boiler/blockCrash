using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    class OnajimisanBuilder : StageBuilder
    {
        public override void CreateStage(out Block[] block, ref int sumblock, bool extendOn)
        {
            sumblock = 28;

            block = new Block[sumblock];

            //ブロックの間を5ピクセルあけて、横7列、縦4行で配置
            for (int i = 0; i < sumblock; ++i)
            {
                if (i < 7)
                    block[i] = new Block(80 + (5 + 100) * i, 50 * 1 + 10, extendOn, EBlockColor.RED);
                else if (i > 6 && i < 14)
                    block[i] = new Block(80 + (5 + 100) * (i - 7), 50 * 2 + 10, extendOn, EBlockColor.BLUE);
                else if (i > 13 && i < 21)
                    block[i] = new Block(80 + (5 + 100) * (i - 14), 50 * 3 + 10, extendOn, EBlockColor.PURPLE);
                else
                    block[i] = new Block(80 + (5 + 100) * (i - 21), 50 * 4 + 10, extendOn, EBlockColor.CYAN);
            }
        }

        public override void BlockProcess(Input input, Graphics g, UserChoice uc, TakeOver takeOver, Block[] block, ref int ballDeadCount, int sumblock)
        {
            for (int i = 0; i < sumblock; ++i)
            {
                if (block[i].IsDead)
                    ++ballDeadCount;

                if (i < 7)
                    block[i].Process(input, g, uc, takeOver);
                else if (i > 6 && i < 14)
                    block[i].Process(input, g, uc, takeOver);
                else if (i > 13 && i < 21)
                    block[i].Process(input, g, uc, takeOver);
                else
                    block[i].Process(input, g, uc, takeOver);
            }
        }
    }
}
