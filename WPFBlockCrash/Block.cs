using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WPFBlockCrash
{
    enum EItemType
    {
        ITEMTYPE_LONG,
        ITEMTYPE_POWERUP,
        ITEMTYPE_INCRESE,
        ITEMTYPE_1UP,
        ITEMTYPE_SCOREUP,
        ITEMTYPE_BALLCATCHER,
        ITEMTYPE_NO,
    }

    enum EBlockColor
    {
        RED,
        BLUE,
        PURPLE,
        CYAN
    }

    class Block : IInputable
    {
        private static bool IsFirstInstance = true;
        private static Image[] gh = new Image[8];
        private static Image[] itemgh = new Image[6];

        private bool half;
        private int count;

        //public int BlockNumber { get; private set; }
        public int ImageHandle { get; set; }

        // スクロールブロック用変数,0=スクロールなし,1=右スクロール,-1=左スクロール
        private int scroll = 0;
        // スクロールカウント
        private int scrollcount = 0;

        // スクロール時にブロック破壊と同時にアイテムを取得しないように変数を実装
        public int matchlesscount = 0;

        public EItemType ItemType { get; private set; }
        public EBlockColor BlockColor { get; private set; }

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int ItemWidth { get; private set; }
        public int ItemHeight { get; private set; }

        private bool isdead;
        public bool scrollStop;
        public bool barextend;
        public bool IsDead
        {
            get { return isdead; }
            set
            {
                bool old = isdead;
                isdead = value;
                if (value == true && ItemFlag) {
                    matchlesscount = 10; // 10フレーム無敵に                    
                }
                if (!old && isdead)
                    Debug.WriteLine("A Block is dead now. (" + X + ", " + Y + ")");
            }
        }

        private bool itemflag;
        public bool ItemFlag
        {
            get { return itemflag; }
            set
            {
                if (itemflag && !value)
                    WasItem = true;
                itemflag = value;
            }
        }

        private bool WasItem;
        public bool HalfFlag
        {
            get { return half; }
            set
            {
                half = value;
                if (half)
                {
                    Width /= 2;
                }
            }
        }
        // ブロックのスクロールを制御する関数
        public int ScrollFlag
        {
            set
            {
                scroll = value;
                scrollStop = false;
            }
        }

        public Block(int x, int y, bool extendon, EBlockColor blockColor)
        {
            if (IsFirstInstance)
            {
                gh = new Image[8];
                itemgh = new Image[6];

                gh[0] = new Bitmap(Main.ResourceDirectory + "block1.bmp");
                gh[1] = new Bitmap(Main.ResourceDirectory + "block2.bmp");
                gh[2] = new Bitmap(Main.ResourceDirectory + "block3.bmp");
                gh[3] = new Bitmap(Main.ResourceDirectory + "block4.bmp");
                gh[4] = new Bitmap(Main.ResourceDirectory + "block1in.bmp");
                gh[5] = new Bitmap(Main.ResourceDirectory + "block2in.bmp");
                gh[6] = new Bitmap(Main.ResourceDirectory + "block3in.bmp");
                gh[7] = new Bitmap(Main.ResourceDirectory + "block4in.bmp");

                itemgh[0] = new Bitmap(Main.ResourceDirectory + "item_long.bmp");
                itemgh[1] = new Bitmap(Main.ResourceDirectory + "item_powerup.bmp");
                itemgh[2] = new Bitmap(Main.ResourceDirectory + "item_increse.bmp");
                itemgh[3] = new Bitmap(Main.ResourceDirectory + "item_1up.bmp");
                itemgh[4] = new Bitmap(Main.ResourceDirectory + "item_scoreup.bmp");
                itemgh[5] = new Bitmap(Main.ResourceDirectory + "item_mag.bmp");

                IsFirstInstance = false;
            }

            Bitmap bs = gh[0] as Bitmap;
            Bitmap bsitem = itemgh[0] as Bitmap;
                        
            Width = (int)bs.Width;
            Height = (int)bs.Height;
            ItemWidth = (int)bsitem.Width;
            ItemHeight = (int)bsitem.Height;

            BlockColor = blockColor;
            barextend = extendon;
            IsDead = false;
            
#if true
            int r = Main.rand.Next() % 5;
            //int r = 1; デバック用
            if (r == 1)
            {
                itemflag = true;
                if (barextend) // バーが伸びる状態
                    ItemType = (EItemType)(Main.rand.Next() % 6);
                else {
                     ItemType = (EItemType)((Main.rand.Next() % 5) + 1 );
                }
                    
                
            }
            else
            {
                itemflag = false;
                ItemType = EItemType.ITEMTYPE_NO;
            }
#else
            ItemFlag = true;
            ItemType = EItemType.ITEMTYPE_INCRESE;
#endif

            this.X = x;
            this.Y = y;

            count = 0;
            half = false;
        }

        public ProcessResult Process(Input input, Graphics g, UserChoice uc, TakeOver takeOver)
        {
            CalculatePosition();

            Draw(g);

            if (matchlesscount > 0)
                --matchlesscount;

            return new ProcessResult() { IsDead = IsDead };
        }

        private void Draw(Graphics g)
        {
            if (!IsDead)
            {
                if (scrollcount > 0)
                    g.DrawImage(gh[(int)BlockColor], scrollcount - Width, Y - Height / 2, Width, Height);

                g.DrawImage(gh[(int)BlockColor], X - Width / 2, Y - Height / 2, Width, Height);
            }
            else if (ItemFlag)
            {
                if (half)
                {
                    if (scrollcount > 0)
                        g.DrawImage(itemgh[(int)ItemType], scrollcount - Width, Y - Height / 2, Width, Height);

                    g.DrawImage(itemgh[(int)ItemType], X - Width / 2, Y - Height / 2, Width, Height);
                }
                else
                {
                    if (scrollcount > 0)
                        g.DrawImage(itemgh[(int)ItemType], scrollcount - ItemWidth, Y - Height / 2, ItemWidth, ItemHeight);

                    g.DrawImage(itemgh[(int)ItemType], X - ItemWidth / 2, Y - ItemHeight / 2, ItemWidth, ItemHeight);
                }
            }
            else 
            {
                if (count < 20)
                {
                    float opacity = (255f / 40) * (20 - count) / byte.MaxValue;

                    if (scrollcount > 0)
                    {
                        if (WasItem)
                            g.DrawImage(DrawUtil.SetOpacity(itemgh[(int)ItemType], opacity), scrollcount - ItemWidth / 2, Y - ItemHeight / 2, ItemWidth, ItemHeight);
                        else
                            g.DrawImage(DrawUtil.SetOpacity(gh[(int)BlockColor], opacity), scrollcount - Width, Y - Height / 2, Width, Height);
                    }

                    if (WasItem)
                        g.DrawImage(DrawUtil.SetOpacity(itemgh[(int)ItemType], opacity), X - ItemWidth / 2, Y - ItemHeight / 2, ItemWidth, ItemHeight);
                    else
                        g.DrawImage(DrawUtil.SetOpacity(gh[(int)BlockColor], opacity), X - Width / 2, Y - Height / 2, Width, Height);

                    ++count;
                }
            }
        }

        private void CalculatePosition()
        {
            if (!scrollStop) // スクロールストップフラグが立ってたらストップ
            {
                if (scroll == 1)// 右スクロール
                {
                    X += (int)Main.RunningSpeedFactor;
                    
                    if (X + Width / 2 >= 800)//画面外に出たら逆の画面へ
                    {
                        scrollcount = X + Width / 2 - 800;
                    }

                    if (X - Width / 2 >= 800)
                    {
                        X -= 800;
                        scrollcount = 0;
                    }
                }

                if (scroll == -1)// 左スクロール
                {
                    X -= (int)Main.RunningSpeedFactor;
                    
                    if (X - Width / 2 < 0)//画面外に出たら逆の画面へ
                    {
                        scrollcount = X + Width / 2 + 800;
                    }
                    
                    if (X + Width / 2 < 0)
                    {
                        X += 800;
                        scrollcount = 0;
                    }
                }
            }
        }
    }
}
