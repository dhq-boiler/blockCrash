using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    class Input
    {
        public Input()
        {
            key256 = new char[256];
        }

        public void Clear()
        {
            ClearLarger();
            ClearSmaller();
        }

        public void ClearLarger()
        {
            RB = LB = EB = false;
        }

        public void ClearSmaller()
        {
            rB = lB = eB = false;
        }

        //入力状態変数
        public bool RB { get; set; }

        //入力状態変数
        public bool LB { get; set; }

        //入力状態変数
        public bool EB { get; set; }

        //スレッドによる複数操作防止変数
        public bool IsPushedKeys { get; set; }

        //スレッドによる複数操作防止変数
        public bool rB { get; set; }

        //スレッドによる複数操作防止変数
        public bool lB { get; set; }

        //スレッドによる複数操作防止変数
        public bool eB { get; set; }
        

        public bool AT { get; set; }
        public bool IsFinished { get; set; }
        public int barx { get; set; }
        public char[] key256 { get; set; }
    }
}
