﻿using System;
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
        ITEMTYPE_NO
    }

    class Block
    {
        private static bool IsFirstInstance = true;
        private static ImageSource[] gh = new ImageSource[8];
        private static ImageSource[] itemgh = new ImageSource[5];

        private bool half;
        private int count;

        public EItemType ItemType { get; private set; }

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int ItemWidth { get; private set; }
        public int ItemHeight { get; private set; }

        private bool isdead;
        public bool IsDead
        {
            get { return isdead; }
            set
            {
                bool old = isdead;
                isdead = value;
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

        public Block(int x, int y)
        {
            if (IsFirstInstance)
            {
                gh = new ImageSource[8];
                itemgh = new ImageSource[5];

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

                IsFirstInstance = false;
            }

            BitmapImage bs = gh[0] as BitmapImage;
            BitmapImage bsitem = itemgh[0] as BitmapImage;
                        
            Width = (int)bs.PixelWidth;
            Height = (int)bs.PixelHeight;
            ItemWidth = (int)bsitem.PixelWidth;
            ItemHeight = (int)bsitem.PixelHeight;

            IsDead = false;

            //Random rand = new Random(Environment.TickCount);
#if true
            int r = Main.rand.Next() % 5;
            if (r == 1)
            {
                ItemFlag = true;
                ItemType = (EItemType)(Main.rand.Next() % 5);
            }
            else
            {
                ItemFlag = false;
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
        }

        private void Draw(DrawingContext dc, int blockhandle)
        {
            if (half)
            {
                if (!IsDead)
                    DrawUtil.DrawExtendGraph(dc, X - Width / 2, Y - Height / 2, X + Width / 2, Y + Height / 2, gh[blockhandle]);
                else if (ItemFlag)
                    DrawUtil.DrawExtendGraph(dc, X - Width / 2, Y - Height / 2, X + Width / 2, Y + Height / 2, itemgh[(int)ItemType]);
                else
                {
                    if (count < 20)
                    {
                        dc.PushOpacity((255d / 40) * (20 - count) / byte.MaxValue);
                        DrawUtil.DrawExtendGraph(dc, X - Width / 2, Y - Height / 2, X + Width / 2, Y + Height / 2, WasItem ? itemgh[(int)ItemType] : gh[blockhandle]);
                        dc.Pop();
                        ++count;
                    }
                }
            }
            else
            {
                if (!IsDead)
                    DrawUtil.DrawExtendGraph(dc, X - Width / 2, Y - Height / 2, X + Width / 2, Y + Height / 2, gh[blockhandle]);
                else if (ItemFlag)
                    DrawUtil.DrawExtendGraph(dc, X - ItemWidth / 2, Y - ItemHeight / 2, X + Width / 2, Y + Height / 2, itemgh[(int)ItemType]);
                else
                {
                    if (count < 20)
                    {
                        dc.PushOpacity((255d / 40) * (20 - count) / byte.MaxValue);
                        DrawUtil.DrawExtendGraph(dc, X - Width / 2, Y - Height / 2, X + Width / 2, Y + Height / 2, WasItem ? itemgh[(int)ItemType] : gh[blockhandle]);
                        dc.Pop();
                        ++count;
                    }
                }
            }
        }
    }
}
