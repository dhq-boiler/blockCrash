using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    class StageSelect
    {
        private Input input;
        private bool endFlag;
        private int[] bargh;
        private int ballgh;
        private int[] stagegh;
        private int[] sdetailgh;
        private bool[] clear;
        private int sselectgh;
        private int cleargh;
        private bool selectFlag;
        private bool decisionFlag;
        private int sh;
        private int dh;
        private int keycount;
        private int enterCount;
        private int autocount;

        public int mScore { get; set; }
        public int mStock { get; set; }
        public int mStage { get; set; }
        public int mBar { get; set; }

        public StageSelect(Input input)
        {
            this.input = input;

            bargh = new int[3];
            stagegh = new int[6];
            sdetailgh = new int[6];
            clear = new bool[6];
        }

        public void SetFlag(bool flag)
        {
            this.endFlag = flag;
        }

        public bool All()
        {
            return false;
        }

        public void SetValue(int bar, int stage, int score, int stock)
        {
            mBar = bar;
            clear[stage - 1] = true;
            mScore = score;
            mStock = stock;
        }

        internal void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
