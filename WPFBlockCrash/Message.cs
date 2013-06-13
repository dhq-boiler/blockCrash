using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    class Message
    {
        private Input input;
        private int p1;
        private int p2;

        public Message(Input input)
        {
            this.input = input;
        }

        public Message(int p1, int p2)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
        }

        internal bool All()
        {
            throw new NotImplementedException();
        }
    }
}
