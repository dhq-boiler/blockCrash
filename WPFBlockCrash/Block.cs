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

        private int vanishingCount;

        public int ImageHandle { get; set; }

        /// <summary>
        /// スクロールカウント
        /// </summary>
        private int scrollCount = 0;

        /// <summary>
        /// スクロール時にブロック破壊と同時にアイテムを取得することを防ぐ
        /// </summary>
        public int matchlessCount = 0;

        public EItemType ItemType { get; private set; }
        public EBlockColor BlockColor { get; private set; }

        public int CenterX { get; private set; }
        public int CenterY { get; private set; }

        private int _Width;
        public int Width
        {
            get
            {
                if (IsHalf)
                    return _Width / 2;
                else
                    return _Width;
            }
            set
            {
                _Width = value;
            }
        }

        public int Height { get; private set; }
        public int Top { get { return CenterY - Height / 2; } }
        public int Bottom { get { return CenterY + Height / 2; } }
        public int Left { get { return CenterX - Width / 2; } }
        public int Right { get { return CenterX + Width / 2; } }
        public int ItemWidth { get; private set; }
        public int ItemHeight { get; private set; }
        public int DX { get; set; }
        public int DY { get; set; }

        public bool _IsDead;
        public bool BarExtendable { get; private set; }
        public bool IsDead
        {
            get { return _IsDead; }
            set
            {
                bool old = _IsDead;
                _IsDead = value;

                if (value == true && IncludesItem)
                {
                    matchlessCount = 10; // 10フレーム無敵に    
                    IsItem = true;
                }

                if (!old && _IsDead)
                    Debug.WriteLine("A Block is dead now. (" + CenterX + ", " + CenterY + ")");
            }
        }

        private readonly bool _IncludesItem;
        public bool IncludesItem { get { return _IncludesItem; } }

        private bool itemflag;
        public bool IsItem
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
                return IncludesItem ? 4 : 0;
            }
        }

        private bool WasItem;

        public bool IsHalf { get; set; }

        private bool _IsScrolling;
        private int _ScrollVector;

        /// <summary>
        /// 0=スクロールなし,1=右スクロール,-1=左スクロール
        /// </summary>
        public int ScrollVector
        {
            get { return _ScrollVector; }
            set { _ScrollVector = value; }
        }

        // ブロックのスクロールを制御する関数
        public bool IsScrolling
        {
            get { return _IsScrolling; }
            set { _IsScrolling = value; }
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

        public Block(int x, int y, bool extendOn, EBlockColor blockColor)
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
            BarExtendable = extendOn;
            IsDead = false;
           
            int r = Main.rand.Next() % 5;
            if (r == 1)
            {
                _IncludesItem = true;
                if (BarExtendable) // バーが伸びる状態
                    ItemType = (EItemType)(Main.rand.Next() % 6);
                else
                    ItemType = (EItemType)((Main.rand.Next() % 5) + 1 );
            }
            else
            {
                _IncludesItem = false;
                ItemType = EItemType.ITEMTYPE_NO;
            }

            this.CenterX = x;
            this.CenterY = y;

            vanishingCount = 0;
            IsHalf = false;
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
                {
                    g.DrawImage(gh[(int)BlockColor + ItemHandleOffset], scrollCount - Width, CenterY - Height / 2, Width, Height);
                    DrawUtil.Debug_DrawBlockRectangle(g, scrollCount - Width, CenterY - Height / 2, Width, Height);
                }

                g.DrawImage(gh[(int)BlockColor + ItemHandleOffset], CenterX - Width / 2, CenterY - Height / 2, Width, Height);
                DrawUtil.Debug_DrawBlockRectangle(g, CenterX - Width / 2, CenterY - Height / 2, Width, Height);
            }
            else if (IsItem)
            {
                if (IsHalf)
                {
                    if (IsMirroring)
                    {
                        g.DrawImage(itemgh[(int)ItemType], scrollCount - Width, CenterY - Height / 2, Width, Height);
                        DrawUtil.Debug_DrawBlockRectangle(g, scrollCount - Width, CenterY - Height / 2, Width, Height);
                    }

                    g.DrawImage(itemgh[(int)ItemType], CenterX - Width / 2, CenterY - Height / 2, Width, Height);
                    DrawUtil.Debug_DrawBlockRectangle(g, CenterX - Width / 2, CenterY - Height / 2, Width, Height);
                }
                else
                {
                    if (IsMirroring)
                    {
                        g.DrawImage(itemgh[(int)ItemType], scrollCount - ItemWidth, CenterY - Height / 2, ItemWidth, ItemHeight);
                        DrawUtil.Debug_DrawBlockRectangle(g, scrollCount - ItemWidth, CenterY - Height / 2, ItemWidth, ItemHeight);
                    }

                    g.DrawImage(itemgh[(int)ItemType], CenterX - ItemWidth / 2, CenterY - ItemHeight / 2, ItemWidth, ItemHeight);
                    DrawUtil.Debug_DrawBlockRectangle(g, CenterX - ItemWidth / 2, CenterY - ItemHeight / 2, ItemWidth, ItemHeight);
                }
            }
            else 
            {
                DrawVanishingGradually(g);
            }
        }

        private void DrawVanishingGradually(Graphics g)
        {
            //ブロックが徐々に消える描画処理
            if (vanishingCount < 20)
            {
                float opacity = (255f / 40) * (20 - vanishingCount) / byte.MaxValue;

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

                ++vanishingCount;
            }
        }

        private void CalculatePosition()
        {
            if (IsScrolling) // スクロールストップフラグが立ってたらストップ
            {
                if (ScrollVector == 1)// 右スクロール
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

                if (ScrollVector == -1)// 左スクロール
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
