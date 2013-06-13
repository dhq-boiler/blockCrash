using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    class Bar
    {

        private Input input;
        private int barnum;

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Bar(Input input)
        {
            this.input = input;
        }

        public Bar(Input input, int barnum)
        {
            this.barnum = barnum;
        }

        internal void All()
        {
            throw new NotImplementedException();
        }

        public int MX { get; set; }

        public bool Flag { get; set; }
    }
}
