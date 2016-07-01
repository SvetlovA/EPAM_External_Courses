using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    public interface IFieldElements
    {
        int Height { get; }
        int Width { get; }
        int X { get; }
        int Y { get; }
    }
}