using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    class FourTowerBuilder : StageBuilder
    {
        public override void CreateStage(out Block[] block, ref int sumblock, bool extendOn)
        {
            sumblock = 48;

            block = new Block[sumblock];

            //ブロックの上下間を30ピクセルあけて、横4列、縦12行で配置
            for (int i = 0; i < sumblock; ++i)
            {
                if (i < 4)
                    block[i] = new Block(50 + (8 + 225) * i, 30 * 1 + 15, extendOn, EBlockColor.RED);
                else if (i > 3 && i < 8)
                    block[i] = new Block(50 + (8 + 225) * (i - 4), 30 * 2 + 15, extendOn, EBlockColor.BLUE);
                else if (i > 7 && i < 12)
                    block[i] = new Block(50 + (8 + 225) * (i - 8), 30 * 3 + 15, extendOn, EBlockColor.PURPLE);
                else if (i > 11 && i < 16)
                    block[i] = new Block(50 + (8 + 225) * (i - 12), 30 * 4 + 15, extendOn, EBlockColor.CYAN);
                else if (i > 15 && i < 20)
                    block[i] = new Block(50 + (8 + 225) * (i - 16), 30 * 5 + 15, extendOn, EBlockColor.RED);
                else if (i > 19 && i < 24)
                    block[i] = new Block(50 + (8 + 225) * (i - 20), 30 * 6 + 15, extendOn, EBlockColor.BLUE);
                else if (i > 23 && i < 28)
                    block[i] = new Block(50 + (8 + 225) * (i - 24), 30 * 7 + 15, extendOn, EBlockColor.PURPLE);
                else if (i > 27 && i < 32)
                    block[i] = new Block(50 + (8 + 225) * (i - 28), 30 * 8 + 15, extendOn, EBlockColor.CYAN);
                else if (i > 31 && i < 36)
                    block[i] = new Block(50 + (8 + 225) * (i - 32), 30 * 9 + 15, extendOn, EBlockColor.RED);
                else if (i > 35 && i < 40)
                    block[i] = new Block(50 + (8 + 225) * (i - 36), 30 * 10 + 15, extendOn, EBlockColor.BLUE);
                else if (i > 39 && i < 44)
                    block[i] = new Block(50 + (8 + 225) * (i - 40), 30 * 11 + 15, extendOn, EBlockColor.PURPLE);
                else
                    block[i] = new Block(50 + (8 + 225) * (i - 44), 30 * 12 + 15, extendOn, EBlockColor.CYAN);
            }
        }
    }
}
