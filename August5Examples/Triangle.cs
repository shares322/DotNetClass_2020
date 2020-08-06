using System;
using System.Collections.Generic;
using System.Text;

namespace August5Examples
{
    class Triangle : IShape
    {
        public double S1Length { get; set; }
        public double S2Length { get; set; } 
        public double S3Length { get; set; }
        public int NumberOfSides { get ; set ; }

        public double CalculateArea()
        {
            var semiPerim = CalculatePerimeter() / 2;
            var triArea = Math.Sqrt(semiPerim * (semiPerim - S1Length) * (semiPerim - S2Length) * (semiPerim - S3Length));
            return Math.Round(triArea, 2);
        }

        public Triangle(double s1Length, double s2Length, double s3Length)
        {
            S1Length = s1Length;
            S2Length = s2Length;
            S3Length = s3Length;
            NumberOfSides = 3;
        }

        public double CalculatePerimeter()
        {
            return S1Length + S2Length + S3Length;
        }
    }
}
