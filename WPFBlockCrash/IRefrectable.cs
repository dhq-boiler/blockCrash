using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBlockCrash
{
    interface IRefrectable
    {
        int CenterX { get; set; }
        int CenterY { get; set; }
        int Width { get; }
        int Height { get; }
        int DX { get; set; }
        int DY { get; set; }
        int Top { get; }
        int Left { get; }
        int Right { get; }
        int Bottom { get; }
    }
}
