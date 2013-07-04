using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    class CrossCrossBuilder : StageBuilder
    {
        public override void CreateStage(out Block[] block, ref int sumblock, bool extendOn)
        {
            sumblock = 48;

            block = new Block[sumblock];

            //ブロックの上下間を5ピクセルあけて、横3列、縦8行で配置
            for (int i = 0; i < sumblock; ++i)
            {
                if (i < 4)
                    block[i] = new Block(55 + (8 + 180) * i, 30 * 1 + 15, extendOn, EBlockColor.RED);
                else if (i > 3 && i < 8)
                    block[i] = new Block(145 + (8 + 180) * (i - 4), 30 * 2 + 15, extendOn, EBlockColor.BLUE);
                else if (i > 7 && i < 12)
                    block[i] = new Block(55 + (8 + 180) * (i - 8), 30 * 3 + 15, extendOn, EBlockColor.PURPLE);
                else if (i > 11 && i < 16)
                    block[i] = new Block(145 + (8 + 180) * (i - 12), 30 * 4 + 15, extendOn, EBlockColor.CYAN);
                else if (i > 15 && i < 20)
                    block[i] = new Block(55 + (8 + 180) * (i - 16), 30 * 5 + 15, extendOn, EBlockColor.RED);
                else if (i > 19 && i < 24)
                    block[i] = new Block(145 + (8 + 180) * (i - 20), 30 * 6 + 15, extendOn, EBlockColor.BLUE);
                else if (i > 23 && i < 28)
                    block[i] = new Block(55 + (8 + 180) * (i - 24), 30 * 7 + 15, extendOn, EBlockColor.PURPLE);
                else if (i > 27 && i < 32)
                    block[i] = new Block(145 + (8 + 180) * (i - 28), 30 * 8 + 15, extendOn, EBlockColor.CYAN);
                else if (i > 31 && i < 36)
                    block[i] = new Block(55 + (8 + 180) * (i - 32), 30 * 9 + 15, extendOn, EBlockColor.RED);
                else if (i > 35 && i < 40)
                    block[i] = new Block(145 + (8 + 180) * (i - 36), 30 * 10 + 15, extendOn, EBlockColor.BLUE);
                else if (i > 39 && i < 44)
                    block[i] = new Block(55 + (8 + 180) * (i - 40), 30 * 11 + 15, extendOn, EBlockColor.PURPLE);
                else
                    block[i] = new Block(145 + (8 + 180) * (i - 44), 30 * 12 + 15, extendOn, EBlockColor.CYAN);

                if (i % 2 == 0)
                    block[i].ScrollFlag = 1;
                else
                    block[i].ScrollFlag = -1;
            }
        }

        public override void BlockProcess(Input input, System.Drawing.Graphics g, UserChoice uc, TakeOver takeOver, Block[] block, ref int ballDeadCount, int sumblock)
        {
            StageUtil.CommonBlockProcess(input, g, uc, takeOver, block, ref ballDeadCount, sumblock);
        }
    }
}
