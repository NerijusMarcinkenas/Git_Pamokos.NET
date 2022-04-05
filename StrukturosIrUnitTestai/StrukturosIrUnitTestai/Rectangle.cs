using System;
using System.Collections.Generic;
using System.Text;

namespace StrukturosIrUnitTestai
{
    public struct Rectangle
    {
        public string RactangleName;
        public double Length;
        public double Width;

        public Rectangle(string ractangleName, double length, double width)
        {
            Length = length;
            Width = width;
            RactangleName = ractangleName;
        }

        public double GetArea(double length, double width)
        {
            return Length * Width;

        }
    }
}
