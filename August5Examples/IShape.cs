using System;
using System.Collections.Generic;
using System.Text;

namespace August5Examples
{
    public interface IShape
    {
        public int NumberOfSides { get; set; }

        public double CalculateArea();
        public double CalculatePerimeter();             
       
    }
}
