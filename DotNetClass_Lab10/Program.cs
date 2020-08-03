using System;

namespace DotNetClass_Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ansYes = true;
            int count = 1;
            Console.WriteLine("Welcome to the Circle Tester:");
            Console.WriteLine();

            do
            {
                Console.WriteLine("Please enter a radius: ");
                var userInput = Console.ReadLine();

                double aDouble;
                if (!double.TryParse(userInput, out aDouble))
                {
                    Console.WriteLine("That was not a number.  Please try again.");
                    Console.WriteLine();
                }
                else 
                {
                    var radius = double.Parse(userInput);
                    var circle = new Circle(radius);

                    Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference()}.");
                    Console.WriteLine($"Area: {circle.CalculateFormattedArea()}.");

                    Console.WriteLine("Would you like to continue? y/n: ");
                    string continueAnswer = Console.ReadLine();
                    char.TryParse(continueAnswer, out char contAnswer);

                    if (contAnswer == 'y' || contAnswer == 'Y')
                    {
                        ansYes = true;
                        count++;
                    }
                    else
                    {
                        ansYes = false;
                    }
                }
 
            } while (ansYes == true);

            int countLoops = count;
            Console.WriteLine("Good-bye. You created " + countLoops + " Circle object(s).");
        }
        
    }
}
