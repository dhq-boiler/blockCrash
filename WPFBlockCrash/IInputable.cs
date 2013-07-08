using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    class UserChoice
    {
        public EBarType BarType { get; set; }
        public EStageType StageType { get; set; }
    }

    class TakeOver
    {
        public DisplayInfo DisplayInfo { get; set; }
        public int Score { get; set; }
        public int Stock { get; set; }
    }

    class ProcessResult
    {
        public bool IsDead { get; set; }
        public IInputable NextState { get; set; }
        public UserChoice UserChoice { get; set; }
        public TakeOver TakeOver { get; set; }
    }

    interface IInputable
    {
        ProcessResult Process(Input input, Graphics g, UserChoice userChoice, TakeOver takeOver);

        bool IsDead { get; set; }
    }
}
