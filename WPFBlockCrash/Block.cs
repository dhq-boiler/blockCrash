using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WPFBlockCrash
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
        //private int x, y;
        private int width, height, itemwidth, itemheight;
        //private bool endflag;

        //private static int[] gh;
        //private static int[] itemgh;

        private static bool IsFirstInstance = false;
        private static Image[] gh = new Image[8];
        private static Image[] itemgh = new Image[5];

        private bool half;
        private int count;

        //public bool itemflag { get; set; }
        public ItemType it { get; private set; }

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public bool EndFlag { get; set; }
        public bool ItemFlag { get; set; }
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
                gh[0] = new Image() { Source = new BitmapImage(new Uri("block1.bmp")) };
                gh[1] = new Image() { Source = new BitmapImage(new Uri("block2.bmp")) };
                gh[2] = new Image() { Source = new BitmapImage(new Uri("block3.bmp")) };
                gh[3] = new Image() { Source = new BitmapImage(new Uri("block4.bmp")) };
                gh[4] = new Image() { Source = new BitmapImage(new Uri("block1in.bmp")) };
                gh[5] = new Image() { Source = new BitmapImage(new Uri("block2in.bmp")) };
                gh[6] = new Image() { Source = new BitmapImage(new Uri("block3in.bmp")) };
                gh[7] = new Image() { Source = new BitmapImage(new Uri("block4in.bmp")) };

                itemgh[0] = new Image() { Source = new BitmapImage(new Uri("item_long.bmp")) };
                itemgh[1] = new Image() { Source = new BitmapImage(new Uri("item_powerup.bmp")) };
                itemgh[2] = new Image() { Source = new BitmapImage(new Uri("item_increse.bmp")) };
                itemgh[3] = new Image() { Source = new BitmapImage(new Uri("item_1up.bmp")) };
                itemgh[4] = new Image() { Source = new BitmapImage(new Uri("item_scoreup.bmp")) };

                IsFirstInstance = false;
            }

            width = (int)gh[0].ActualWidth;
            height = (int)gh[0].ActualHeight;
            itemwidth = (int)itemgh[0].ActualWidth;
            itemheight = (int)itemgh[0].ActualHeight;

            EndFlag = false;

            Random rand = new Random(Environment.TickCount);
            int r = rand.Next() % 5;
            if (r == 1)
            {
                ItemFlag = true;
                it = (ItemType)(rand.Next() % 5);
            }
            else
            {
                ItemFlag = false;
                it = (ItemType)0;
            }

            this.X = x;
            this.Y = y;

            count = 0;
            half = false;
        }

        internal void All(int p)
        {
            throw new NotImplementedException();
        }
    }
}
