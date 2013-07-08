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

        public int ImageHandle { get; set; }

        // スクロールブロック用変数,0=スクロールなし,1=右スクロール,-1=左スクロール
        private int ScrollDirection = 0;
        // スクロールカウント
        private int scrollCount = 0;

        // スクロール時にブロック破壊と同時にアイテムを取得しないように変数を実装
        public int matchlessCount = 0;

        public EItemType ItemType { get; private set; }
        public EBlockColor BlockColor { get; private set; }

        public int CenterX { get; private set; }
        public int CenterY { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Top { get { return CenterY - Height / 2; } }
        public int Bottom { get { return CenterY + Height / 2; } }
        public int Left { get { return CenterX - Width / 2; } }
        public int Right { get { return CenterX + Width / 2; } }
        public int ItemWidth { get; private set; }
        public int ItemHeight { get; private set; }
        public int dx;
        public int DX { get { return dx; } set { dx = value; } }
        public int dy;
        public int DY { get { return dy; } set { dy = value; } }

        public bool isdead;
        public bool scrollStop;
        public bool barextend;
        public bool IsDead
        {
            get { return isdead; }
            set
            {
                bool old = isdead;
                isdead = value;

                if (value == true && ItemFlag)
                {
                    matchlessCount = 10; // 10フレーム無敵に                    
                }

                if (!old && isdead)
                    Debug.WriteLine("A Block is dead now. (" + CenterX + ", " + CenterY + ")");
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

        private int ItemHandleOffset
        {
            get
            {
                return ItemFlag ? 4 : 0;
            }
        }

        private bool WasItem; //is used "Release" mode build.
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
        public int IsScrolling
        {
            set
            {
                ScrollDirection = value;
                scrollStop = false;
            }
        }

        /// <summary>
        /// ブロックがスクロールして画面をまたいで判定が存在する時,true
        /// </summary>
        public bool IsMirroring { get; private set; }

        public int MirrorCenterX { get { return MirrorLeft + (MirrorRight - MirrorLeft) / 2; } }
        public int MirrorCenterY { get { return MirrorTop + (MirrorBottom - MirrorTop) / 2; } }
        public int MirrorTop { get { return CenterY - Height / 2; } }       //現状Y方向のスクロールはない
        public int MirrorBottom { get { return CenterY + Height / 2; } }    //現状Y方向のスクロールはない
        public int MirrorLeft { get { return CenterX - Width / 2 - Main.MainInstance.dInfo.Width; } }
        public int MirrorRight { get { return CenterX + Width / 2 - Main.MainInstance.dInfo.Width; } }

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

            this.CenterX = x;
            this.CenterY = y;

            count = 0;
            half = false;
        }

        public ProcessResult Process(Input input, Graphics g, UserChoice uc, TakeOver takeOver)
        {
            CalculatePosition();

            Draw(g);

            if (matchlessCount > 0)
                --matchlessCount;

            return new ProcessResult() { IsDead = IsDead };
        }

        private void Draw(Graphics g)
        {
            if (!IsDead)
            {
                if (IsMirroring)
                    g.DrawImage(gh[(int)BlockColor + ItemHandleOffset], scrollCount - Width, CenterY - Height / 2, Width, Height);

                g.DrawImage(gh[(int)BlockColor + ItemHandleOffset], CenterX - Width / 2, CenterY - Height / 2, Width, Height);
            }
            else if (ItemFlag)
            {
                if (half)
                {
                    if (IsMirroring)
                        g.DrawImage(itemgh[(int)ItemType], scrollCount - Width, CenterY - Height / 2, Width, Height);

                    g.DrawImage(itemgh[(int)ItemType], CenterX - Width / 2, CenterY - Height / 2, Width, Height);
                }
                else
                {
                    if (IsMirroring)
                        g.DrawImage(itemgh[(int)ItemType], scrollCount - ItemWidth, CenterY - Height / 2, ItemWidth, ItemHeight);

                    g.DrawImage(itemgh[(int)ItemType], CenterX - ItemWidth / 2, CenterY - ItemHeight / 2, ItemWidth, ItemHeight);
                }
            }
#if !DEBUG
            else 
            {
                if (count < 20)
                {
                    float opacity = (255f / 40) * (20 - count) / byte.MaxValue;

                    if (IsMirroring)
                    {
                        if (WasItem)
                            g.DrawImage(DrawUtil.SetOpacity(itemgh[(int)ItemType], opacity), scrollCount - ItemWidth / 2, CenterY - ItemHeight / 2, ItemWidth, ItemHeight);
                        else
                            g.DrawImage(DrawUtil.SetOpacity(gh[(int)BlockColor], opacity), scrollCount - Width, CenterY - Height / 2, Width, Height);
                    }

                    if (WasItem)
                        g.DrawImage(DrawUtil.SetOpacity(itemgh[(int)ItemType], opacity), CenterX - ItemWidth / 2, CenterY - ItemHeight / 2, ItemWidth, ItemHeight);
                    else
                        g.DrawImage(DrawUtil.SetOpacity(gh[(int)BlockColor], opacity), CenterX - Width / 2, CenterY - Height / 2, Width, Height);

                    ++count;
                }
            }
#endif
        }

        private void CalculatePosition()
        {
            if (!scrollStop) // スクロールストップフラグが立ってたらストップ
            {
                if (ScrollDirection == 1)// 右スクロール
                {
                    CenterX += (int)Main.RunningSpeedFactor;
                    
                    if (CenterX + Width / 2 >= 800) //画面右外に出始める
                    {
                        IsMirroring = true;
                        scrollCount = CenterX + Width / 2 - 800;
                    }

                    if (CenterX - Width / 2 >= 800) //画面右外に完全に出る
                    {
                        IsMirroring = false;
                        CenterX -= 800;
                        scrollCount = 0;
                    }
                }

                if (ScrollDirection == -1)// 左スクロール
                {
                    CenterX -= (int)Main.RunningSpeedFactor;
                    
                    if (CenterX - Width / 2 < 0) //画面左外に出始める
                    {
                        IsMirroring = true;
                        scrollCount = CenterX + Width / 2 + 800;
                    }
                    
                    if (CenterX + Width / 2 < 0) //画面左外に完全に出る
                    {
                        IsMirroring = false;
                        CenterX += 800;
                        scrollCount = 0;
                    }
                }
            }
        }
    }
}
