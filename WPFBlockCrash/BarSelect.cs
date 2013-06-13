using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    class BarSelect
    {
        private Input input;
        private bool endFlag;
        private int[] barGh;
        private int bSelectGh;
        private bool selectFlag;
        private bool decisionFlag;
        private int sh;
        private int dh;
        private int keyCount;
        private int autoCount;

        public int mBar { get; set; }

        public BarSelect(Input input)
        {
            this.input = input;

            barGh = new int[3];
        }

        public void SetFlag(bool flag)
        {
            endFlag = flag;
        }

        public bool All()
        {
            return false;
        }
    }
}
