using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace August5Examples
{

    class Circle : IShape
    {
        public double Radius { get; set; }
        public int NumberOfSides { get; set; }

        private double radius;


        public Circle(double radius)
        {
            Radius = radius;
            NumberOfSides = 0;
        }

        public double CalculateArea()
        {
            return Math.Round(Math.PI * Radius * Radius, 2);
        }

        public double CalculatePerimeter()
        {
            return Math.Round((2 * Math.PI * Radius), 2);
        }
    }
}
