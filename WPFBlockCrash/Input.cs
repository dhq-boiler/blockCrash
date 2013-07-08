using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    public class Input
    {
        public const int KEY_INPUT_RETURN = 0x1C;
        public const int KEY_INPUT_A = 0x1E;
        public const int KEY_INPUT_SPACE = 0x39;

        public const int KEY_INPUT_LEFT = 0xCB;
        public const int KEY_INPUT_RIGHT = 0xCD;
        public const int KEY_INPUT_ESCAPE = 0x01;

        public Input()
        {
            RB = new KeyInput() { TimeToContinuousInput = TimeSpan.FromMilliseconds(1000) };
            LB = new KeyInput() { TimeToContinuousInput = TimeSpan.FromMilliseconds(1000) };
            EB = new KeyInput() { TimeToContinuousInput = TimeSpan.FromMilliseconds(1000) };
            key256 = new char[256];
        }

        public void Clear()
        {
            ClearSmaller();

            key256 = new char[256];
        }

        public void ClearSmaller()
        {
            rB = lB = eB = false;
        }

        public void ClearArray()
        {
            key256 = new char[256];
        }

        public KeyInput RB { get; set; }
        public KeyInput LB { get; set; }
        public KeyInput EB { get; set; }

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

        public bool IsFinishing { get; set; }
    }
}
