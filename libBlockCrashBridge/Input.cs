using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libBlockCrashBridge
{
    class Input
    {
        public bool RB { get; set; }
        public bool LB { get; set; }
        public bool EB { get; set; }
        public bool rB { get; set; }
        public bool lB { get; set; }
        public bool eB { get; set; }

        public void Clear()
        {
            RB = LB = EB = rB = lB = eB = false;
        }

        public bool Key { get; set; }
        public bool AT { get; set; }
        public int barx { get; set; }
    }
}
