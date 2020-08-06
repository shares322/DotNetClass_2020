using System;
using System.Collections.Generic;
using System.Text;

namespace August5Examples
{
    class Square : IShape
    {
        public int NumberOfSides { get; set; }

        public double SideLength { get; set; }

        public double CalculateArea()
        {
            return SideLength * SideLength;
        }

        public double CalculatePerimeter()
        {
            return SideLength * 4;
        }

        public Square(double sideLength)
        {
            SideLength = sideLength;
            NumberOfSides = 4;
        }
    }
}
