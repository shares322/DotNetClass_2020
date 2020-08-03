using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetClass_Lab10
{
    class Circle
    {
        private int radius;

        public double Radius { get; set; }


        //constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        //method
        public double CalculateCircumference()
        {
            var circumference = 2 * Math.PI * Radius;
            return circumference;
        }

        private string FormatNumber(double x)
        {
            var roundedInput = Math.Round(x, 2);
            return roundedInput.ToString();
            
        }

        public string CalculateFormattedCircumference()
        {
            var circumference = CalculateCircumference();
            return FormatNumber(circumference);
        }

        //method
        public double CalculateArea()
        {
            var area = Math.PI * (Radius * Radius);
            return area;
        }

        public string CalculateFormattedArea()
        {
            var area = CalculateArea();
            return FormatNumber(area);
        }
    }
}
