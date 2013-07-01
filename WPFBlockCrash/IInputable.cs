using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    interface IInputable
    {
        bool Process(Input input, Graphics g);

        bool IsDead { get; set; }
    }
}
