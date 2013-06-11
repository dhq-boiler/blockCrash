using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private static int[] gh;
        private static int[] itemgh;
        private bool half;
        private int count;
        
        private void Draw(int blockhandle)
        {
            throw new NotImplementedException();
        }

        public int GetX()
        {
            throw new NotImplementedException();
        }

        public int GetY()
        {
            throw new NotImplementedException();
        }

        public int GetWidth()
        {
            throw new NotImplementedException();
        }

        public int GetHeight()
        {
            throw new NotImplementedException();
        }

        public void SetFlag(bool flag)
        {
            throw new NotImplementedException();
        }

        public bool GetFlag()
        {
            throw new NotImplementedException();
        }

        public void SetItemFlag(bool flag)
        {
            throw new NotImplementedException();
        }

        public bool GetItemFlag()
        {
            throw new NotImplementedException();
        }

        public void SetHalfFlag(bool flag)
        {
            throw new NotImplementedException();
        }

        public bool itemflag;

        public ItemType it;
    }
}
