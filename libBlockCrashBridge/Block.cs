using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxLibDLL;

namespace libBlockCrashBridge
{
    enum ItemType
    {
        ITEMTYPE_LONG,
        ITEMTYPE_POWERUP,
        ITEMTYPE_INCRESE,
        ITEMTYPE_1UP,
        ITEMTYPE_SCOREUP
    }

    class Block
    {
        private int x;
        private int y;
        private int width;
        private int height;
        private int itemwidth;
        private int itemheight;
        private bool endflag;
        private static int[] gh = new int[8] { -1, -1, -1, -1, -1, -1, -1, -1 };
        private static int[] itemgh = new int[5] { -1, -1, -1, -1, -1 };
        private bool half;
        private int count;


        public const int MAX_BLOCKCOUNT = 100;
        
        private void Draw(int blockhandle)
        {
            if (half)
            {
                //ブロックが壊れてないときだけ描画
                if (!endflag)
                {
                    DX.DrawExtendGraph(x - width / 2, y - height / 2,
                        x + width / 2, y + height / 2, gh[blockhandle], 1);
                }
                else if (itemflag)
                {
                    DX.DrawExtendGraph(x - width / 2, y - height / 2,
                        x + width / 2, y + height / 2, itemgh[(int)it], 1);
                }
                else
                {
                    if (count < 20)
                    {
                        //透過度を指定
                        DX.SetDrawBlendMode(DX.DX_BLENDMODE_ALPHA, (255 / 40) * (20 - count)); //ジョジョに薄くする
                        //描画
                        DX.DrawExtendGraph(x - width / 2, y - height / 2,
                            x + width / 2, y + height / 2, gh[blockhandle], 1);
                        //設定を戻す
                        DX.SetDrawBlendMode(DX.DX_BLENDMODE_NOBLEND, 0);
                        ++count;
                    }
                }
            }
            else
            {
                //ブロックが壊れてないときだけ描画
                if (!endflag)
                {
                    DX.DrawGraph(x - width / 2, y - height / 2, gh[blockhandle], 0);
                }
                else if (itemflag)
                {
                    DX.DrawGraph(x - itemwidth / 2, y - itemheight / 2, itemgh[(int)it], 0);
                }
                else
                {
                    if (count < 20)
                    {
                        //透過度を指定
                        DX.SetDrawBlendMode(DX.DX_BLENDMODE_ALPHA, (255 / 40) * (20 - count)); //ジョジョに薄くする
                        //描画
                        DX.DrawGraph(x - width / 2, y - height / 2, gh[blockhandle], 0);
                        //設定を戻す
                        DX.SetDrawBlendMode(DX.DX_BLENDMODE_NOBLEND, 0);
                        ++count;
                    }
                }
            }
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public void SetFlag(bool flag)
        {
            endflag = false;
        }

        public bool GetFlag()
        {
            return endflag;
        }

        public void SetItemFlag(bool flag)
        {
            itemflag = flag;
        }

        public bool GetItemFlag()
        {
            return itemflag;
        }

        public void SetHalfFlag(bool flag)
        {
            half = flag;
            if (half)
            {
                width /= 2;
            }
        }

        public Block(string filename, int x, int y)
        {
            //最初しか読み込まない
            //一気に読み込めばいいね
            if (gh[0] == -1)
            {
                gh[0] = DX.LoadGraph("block1.bmp");
                gh[1] = DX.LoadGraph("block2.bmp");
                gh[2] = DX.LoadGraph("block3.bmp");
                gh[3] = DX.LoadGraph("block4.bmp");
                gh[4] = DX.LoadGraph("block1in.bmp");
                gh[5] = DX.LoadGraph("block2in.bmp");
                gh[6] = DX.LoadGraph("block3in.bmp");
                gh[7] = DX.LoadGraph("block4in.bmp");
                
            }

            if (itemgh[0] == -1)
            {
                itemgh[0] = DX.LoadGraph("item_long.bmp");
                itemgh[1] = DX.LoadGraph("item_powerup.bmp");
                itemgh[2] = DX.LoadGraph("item_increse.bmp");
                itemgh[3] = DX.LoadGraph("item_1up.bmp");
                itemgh[4] = DX.LoadGraph("item_scoreup.bmp");
            }

            DX.GetGraphSize(gh[0], out width, out height);
            DX.GetGraphSize(itemgh[0], out itemwidth, out itemheight);

            endflag = false;

            //ブロックにアイテムがあるかどうかを判定
            //擬似乱数
            Random rand = new Random(Environment.TickCount);
            int r = rand.Next() % 5;
            if (r == 1)
            {
                itemflag = true;
                it = (ItemType)(rand.Next() % 5);
            }
            else
            {
                itemflag = false;
                it = (ItemType)0;
            }

            this.x = x;
            this.y = y;

            count = 0;
            half = false;
        }

        public void All(int blockhandle)
        {
            Draw(blockhandle);
        }

        public bool itemflag;

        public ItemType it;
    }
}
