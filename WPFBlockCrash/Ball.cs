using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFBlockCrash
{
    class Ball
    {
        private Input input;
        public int m_actcount;

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Ball(Input input)
        {
            this.input = input;
        }

        internal void LvUp(int p)
        {
            throw new NotImplementedException();
        }

        internal void spchange()
        {
            throw new NotImplementedException();
        }

        internal bool All()
        {
            throw new NotImplementedException();
        }

        public int DX { get; set; }

        public int DY { get; set; }
    }
}
