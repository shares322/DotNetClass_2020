using System;

namespace August5Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Square square = new Square(5);
            Triangle triangle = new Triangle(5, 6, 7);


            Console.WriteLine($"Circle area: {circle.CalculateArea()} " +
                              $"\nCircle circumference: {circle.CalculatePerimeter()} " +
                              $"\nCircle number of sides: {circle.NumberOfSides}"); 
            
            
            Console.WriteLine($"\nSquare area: {square.CalculateArea()} " +
                              $"\nSquare circumference: {square.CalculatePerimeter()} " +
                              $"\nSquare number of sides: {square.NumberOfSides}");
            
            Console.WriteLine($"\nTriangle area: {triangle.CalculateArea()} " +
                              $"\nTriangle circumference: {triangle.CalculatePerimeter()} " +
                              $"\nTriangle number of sides: {triangle.NumberOfSides}");
        }
    }
}
