using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    class ProductorIsUsBuilder : StageBuilder
    {
        public override void CreateStage(out Block[] block, ref int sumblock, bool extendOn)
        {
            sumblock = 64;

            block = new Block[sumblock];

            //ブロックの上下間を5ピクセルあけて、横3列、縦8行で配置
            for (int i = 0; i < sumblock; ++i)
            {
                if (i < 4)
                    block[i] = new Block(50 + 50 * i, 50, extendOn, EBlockColor.RED);
                else if (i > 3 && i < 16)
                    block[i] = new Block(125, 50 + 28 * (i - 3), extendOn, EBlockColor.BLUE);
                else if (i > 15 && i < 20)
                    block[i] = new Block(50 + 50 * (i - 16), 50 + 28 * 13, extendOn, EBlockColor.PURPLE);

                else if (i > 19 && i < 21)
                    block[i] = new Block(375, 50, extendOn, EBlockColor.CYAN);
                else if (i > 20 && i < 23)
                    block[i] = new Block(325 + 100 * (i - 21), 50 + 28 * 1, extendOn, EBlockColor.RED);
                else if (i > 22 && i < 25)
                    block[i] = new Block(275 + 200 * (i - 23), 50 + 28 * 2, extendOn, EBlockColor.BLUE);
                else if (i > 24 && i < 27)
                    block[i] = new Block(250 + 250 * (i - 25), 50 + 28 * 3, extendOn, EBlockColor.PURPLE);
                else if (i > 26 && i < 29)
                    block[i] = new Block(250 + 250 * (i - 27), 50 + 28 * 4, extendOn, EBlockColor.CYAN);
                else if (i > 28 && i < 33)
                    block[i] = new Block(250, 50 + 28 * (i - 24), extendOn, EBlockColor.RED);
                else if (i > 32 && i < 35)
                    block[i] = new Block(250 + 250 * (i - 33), 50 + 28 * 9, extendOn, EBlockColor.BLUE);
                else if (i > 34 && i < 37)
                    block[i] = new Block(250 + 250 * (i - 35), 50 + 28 * 10, extendOn, EBlockColor.PURPLE);
                else if (i > 36 && i < 39)
                    block[i] = new Block(275 + 200 * (i - 37), 50 + 28 * 11, extendOn, EBlockColor.CYAN);
                else if (i > 38 && i < 41)
                    block[i] = new Block(325 + 100 * (i - 39), 50 + 28 * 12, extendOn, EBlockColor.RED);
                else if (i > 40 && i < 42)
                    block[i] = new Block(375, 50 + 28 * 13, extendOn, EBlockColor.BLUE);

                else if (i > 41 && i < 44)
                    block[i] = new Block(550 + 50 * (i - 42), 50, extendOn, EBlockColor.PURPLE);
                else if (i > 43 && i < 55)
                    block[i] = new Block(575, 50 + 28 * (i - 43), extendOn, EBlockColor.CYAN);
                else if (i > 54 && i < 57)
                    block[i] = new Block(575 + 175 * (i - 55), 50 + 28 * 11, extendOn, EBlockColor.RED);
                else if (i > 56 && i < 59)
                    block[i] = new Block(575 + 175 * (i - 57), 50 + 28 * 12, extendOn, EBlockColor.BLUE);
                else if (i > 58 && i < 64)
                    block[i] = new Block(550 + 50 * (i - 59), 50 + 28 * 13, extendOn, EBlockColor.PURPLE);

                block[i].HalfFlag = true;
                block[i].IsScrolling = 1;
            }
        }

        public override void BlockProcess(Input input, System.Drawing.Graphics g, UserChoice uc, TakeOver takeOver, Block[] block, ref int ballDeadCount, int sumblock)
        {
            StageUtil.CommonBlockProcess(input, g, uc, takeOver, block, ref ballDeadCount, sumblock);
        }
    }
}
