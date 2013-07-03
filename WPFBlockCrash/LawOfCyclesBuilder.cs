using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    class LawOfCyclesBuilder : StageBuilder
    {
        public override void CreateStage(out Block[] block, ref int sumblock, bool extendOn)
        {
            sumblock = 44;

            block = new Block[sumblock];

            //ブロックの上下間を5ピクセルあけて、横3列、縦8行で配置
            for (int i = 0; i < sumblock; ++i)
            {
                if (i < 1)
                    block[i] = new Block(400, 28 * 1 + 15, extendOn, EBlockColor.RED);
                else if (i > 0 && i < 3)
                    block[i] = new Block(350 + 100 * (i - 1), 28 * 2 + 15, extendOn, EBlockColor.BLUE);
                else if (i > 2 && i < 5)
                    block[i] = new Block(300 + 200 * (i - 3), 28 * 3 + 15, extendOn, EBlockColor.PURPLE);
                else if (i > 4 && i < 7)
                    block[i] = new Block(250 + 300 * (i - 5), 28 * 4 + 15, extendOn, EBlockColor.CYAN);
                else if (i > 6 && i < 9)
                    block[i] = new Block(200 + 400 * (i - 7), 28 * 5 + 15, extendOn, EBlockColor.RED);
                else if (i > 8 && i < 11)
                    block[i] = new Block(150 + 500 * (i - 9), 28 * 6 + 15, extendOn, EBlockColor.BLUE);
                else if (i > 10 && i < 13)
                    block[i] = new Block(100 + 600 * (i - 11), 28 * 7 + 15, extendOn, EBlockColor.PURPLE);
                else if (i > 12 && i < 15)
                    block[i] = new Block(50 + 700 * (i - 13), 28 * 8 + 15, extendOn, EBlockColor.CYAN);
                else if (i > 14 && i < 17)
                    block[i] = new Block(100 + 600 * (i - 15), 28 * 9 + 15, extendOn, EBlockColor.RED);
                else if (i > 16 && i < 19)
                    block[i] = new Block(150 + 500 * (i - 17), 28 * 10 + 15, extendOn, EBlockColor.BLUE);
                else if (i > 18 && i < 21)
                    block[i] = new Block(200 + 400 * (i - 19), 28 * 11 + 15, extendOn, EBlockColor.PURPLE);
                else if (i > 20 && i < 23)
                    block[i] = new Block(250 + 300 * (i - 21), 28 * 12 + 15, extendOn, EBlockColor.CYAN);
                else if (i > 22 && i < 25)
                    block[i] = new Block(300 + 200 * (i - 23), 28 * 13 + 15, extendOn, EBlockColor.RED);
                else if (i > 24 && i < 27)
                    block[i] = new Block(350 + 100 * (i - 25), 28 * 14 + 15, extendOn, EBlockColor.BLUE);
                else if (i > 26 && i < 28)
                    block[i] = new Block(400, 28 * 15 + 15, extendOn, EBlockColor.PURPLE);
                else if (i > 27 && i < 29)
                    block[i] = new Block(400, 28 * 4 + 15, extendOn, EBlockColor.CYAN);
                else if (i > 28 && i < 31)
                    block[i] = new Block(350 + 100 * (i - 29), 28 * 5 + 15, extendOn, EBlockColor.RED);
                else if (i > 30 && i < 33)
                    block[i] = new Block(300 + 200 * (i - 31), 28 * 6 + 15, extendOn, EBlockColor.BLUE);
                else if (i > 32 && i < 35)
                    block[i] = new Block(250 + 300 * (i - 33), 28 * 7 + 15, extendOn, EBlockColor.PURPLE);
                else if (i > 34 && i < 37)
                    block[i] = new Block(200 + 400 * (i - 35), 28 * 8 + 15, extendOn, EBlockColor.CYAN);
                else if (i > 36 && i < 39)
                    block[i] = new Block(250 + 300 * (i - 37), 28 * 9 + 15, extendOn, EBlockColor.RED);
                else if (i > 38 && i < 41)
                    block[i] = new Block(300 + 200 * (i - 39), 28 * 10 + 15, extendOn, EBlockColor.BLUE);
                else if (i > 40 && i < 43)
                    block[i] = new Block(350 + 100 * (i - 41), 28 * 11 + 15, extendOn, EBlockColor.PURPLE);
                else
                    block[i] = new Block(400, 28 * 12 + 15, extendOn, EBlockColor.CYAN);
            }
        }
    }
}
