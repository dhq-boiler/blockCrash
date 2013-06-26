using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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

    class Block
    {
        private static bool IsFirstInstance = true;
        private static ImageSource[] gh = new ImageSource[8];
        private static ImageSource[] itemgh = new ImageSource[6];

        private bool half;
        private int count;

        // スクロールブロック用変数,0=スクロールなし,1=右スクロール,-1=左スクロール
        private int scroll = 0;
        // スクロールカウント
        private int scrollcount = 0;

        // スクロール時にブロック破壊と同時にアイテムを取得しないように変数を実装
        public int matchlesscount = 0;

        public EItemType ItemType { get; private set; }

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

        public Block(int x, int y,bool extendon)
        {
            if (IsFirstInstance)
            {
                gh = new ImageSource[8];
                itemgh = new ImageSource[6];

                gh[0] = new BitmapImage(new Uri(Main.ResourceDirectory, "block1.bmp")) { CreateOptions = BitmapCreateOptions.None };
                gh[1] = new BitmapImage(new Uri(Main.ResourceDirectory, "block2.bmp")) { CreateOptions = BitmapCreateOptions.None };
                gh[2] = new BitmapImage(new Uri(Main.ResourceDirectory, "block3.bmp")) { CreateOptions = BitmapCreateOptions.None };
                gh[3] = new BitmapImage(new Uri(Main.ResourceDirectory, "block4.bmp")) { CreateOptions = BitmapCreateOptions.None };
                gh[4] = new BitmapImage(new Uri(Main.ResourceDirectory, "block1in.bmp")) { CreateOptions = BitmapCreateOptions.None };
                gh[5] = new BitmapImage(new Uri(Main.ResourceDirectory, "block2in.bmp")) { CreateOptions = BitmapCreateOptions.None };
                gh[6] = new BitmapImage(new Uri(Main.ResourceDirectory, "block3in.bmp")) { CreateOptions = BitmapCreateOptions.None };
                gh[7] = new BitmapImage(new Uri(Main.ResourceDirectory, "block4in.bmp")) { CreateOptions = BitmapCreateOptions.None };

                itemgh[0] = new BitmapImage(new Uri(Main.ResourceDirectory, "item_long.bmp")) { CreateOptions = BitmapCreateOptions.None };
                itemgh[1] = new BitmapImage(new Uri(Main.ResourceDirectory, "item_powerup.bmp")) { CreateOptions = BitmapCreateOptions.None };
                itemgh[2] = new BitmapImage(new Uri(Main.ResourceDirectory, "item_increse.bmp")) { CreateOptions = BitmapCreateOptions.None };
                itemgh[3] = new BitmapImage(new Uri(Main.ResourceDirectory, "item_1up.bmp")) { CreateOptions = BitmapCreateOptions.None };
                itemgh[4] = new BitmapImage(new Uri(Main.ResourceDirectory, "item_scoreup.bmp")) { CreateOptions = BitmapCreateOptions.None };
                itemgh[5] = new BitmapImage(new Uri(Main.ResourceDirectory, "item_mag.bmp")) { CreateOptions = BitmapCreateOptions.None };

                IsFirstInstance = false;
            }

            BitmapImage bs = gh[0] as BitmapImage;
            BitmapImage bsitem = itemgh[0] as BitmapImage;
                        
            Width = (int)bs.PixelWidth;
            Height = (int)bs.PixelHeight;
            ItemWidth = (int)bsitem.PixelWidth;
            ItemHeight = (int)bsitem.PixelHeight;

            barextend = extendon;
            IsDead = false;

            //Random rand = new Random(Environment.TickCount);
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

        internal void Process(DrawingContext dc, int blockhandle)
        {
            Draw(dc, blockhandle);
            if (matchlesscount > 0)
                --matchlesscount;
        }

        private void Draw(DrawingContext dc, int blockhandle)
        {
            if (!scrollStop) // スクロールストップフラグが立ってたらストップ
            {
                if (scroll == 1)
                { // 右スクロール
                    ++X;
                    if (X + Width / 2 >= 800)
                    { //画面外に出たら逆の画面へ
                        scrollcount = X + Width / 2 - 800;
                    }
                    if (X - Width / 2 >= 800)
                    {
                        X -= 800;
                        scrollcount = 0;
                    }
                }

                if (scroll == -1)
                { // 左スクロール
                    --X;
                    if (X - Width / 2 < 0)
                    { //画面外に出たら逆の画面へ
                        scrollcount = X + Width / 2 + 800;
                    }
                    if (X + Width / 2 < 0)
                    {
                        X += 800;
                        scrollcount = 0;
                    }
                }
            }

            if (!IsDead)
            {
                if (scrollcount > 0)
                    DrawUtil.DrawExtendGraph(dc, scrollcount - Width, Y - Height / 2, scrollcount, Y + Height / 2, gh[blockhandle]);
                DrawUtil.DrawExtendGraph(dc, X - Width / 2 , Y - Height / 2, X + Width / 2, Y + Height / 2, gh[blockhandle]);
            }
            else if (ItemFlag)
                if (half)
                {
                    if (scrollcount > 0)
                        DrawUtil.DrawExtendGraph(dc, scrollcount - Width, Y - Height / 2, scrollcount, Y + Height / 2, itemgh[(int)ItemType]);
                    DrawUtil.DrawExtendGraph(dc, X - Width / 2, Y - Height / 2, X + Width / 2, Y + Height / 2, itemgh[(int)ItemType]);
                }
                else
                {
                    if (scrollcount > 0)
                        DrawUtil.DrawExtendGraph(dc, scrollcount - ItemWidth, Y - Height / 2, scrollcount, Y + Height / 2, itemgh[(int)ItemType]);
                    DrawUtil.DrawExtendGraph(dc, X - ItemWidth / 2, Y - ItemHeight / 2, X + Width / 2, Y + Height / 2, itemgh[(int)ItemType]);
                }
            else
            {
                if (count < 20)
                {
                    dc.PushOpacity((255d / 40) * (20 - count) / byte.MaxValue);
                    if (scrollcount > 0)
                        DrawUtil.DrawExtendGraph(dc, scrollcount - Width, Y - Height / 2, scrollcount, Y + Height / 2, WasItem ? itemgh[(int)ItemType] : gh[blockhandle]);
                    DrawUtil.DrawExtendGraph(dc, X - Width / 2, Y - Height / 2, X + Width / 2, Y + Height / 2, WasItem ? itemgh[(int)ItemType] : gh[blockhandle]);
                    dc.Pop();
                    ++count;
                }
            }
        }
    }
}
