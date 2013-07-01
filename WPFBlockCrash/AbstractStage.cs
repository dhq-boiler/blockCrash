using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    abstract class AbstractStage : IInputable
    {
        private Block[] block;
        public int BlockCount { get; private set; }
        public int DeadBlockCount { get; private set; }
        public bool IsDead { get; set; }

        public bool Process(Input input, System.Drawing.Graphics g)
        {
            int itemhandle = 0;

            for (int i = 0; i < BlockCount; ++i)
            {
                if (block[i].IsDead)
                    ++BlockCount;
                if (block[i].ItemFlag)
                    itemhandle = 4;

                DrawBlocks(g, block[i], itemhandle);
            }

            return true;
        }

        public abstract void DrawBlocks(Graphics g, Block block, int ImageHandle);

    }
}
