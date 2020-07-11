using System;

namespace DotNet_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            bool ansYes = true;
            
            do
            {
                //Length of room
                Console.WriteLine("Enter Length: ");
                string userLength = Console.ReadLine();

                //parse number to decimal
                decimal.TryParse(userLength, out decimal numLength);

                decimal roomLength = numLength;

                //Width of room
                Console.WriteLine("Enter Width: ");
                string userWidth = Console.ReadLine();

                // parse number to decimal
                decimal.TryParse(userWidth, out decimal numWidth);

                decimal roomWidth = numWidth;

                decimal roomArea = numLength * numWidth;
                decimal roomPerimeter = 2 * (numLength + numWidth);

                string Area = $"The Room Area is {roomWidth} X {roomLength} = {roomArea}";
                string Perimeter = $"The Room Perimeter is 2 X ({roomWidth} + {roomLength}) = {roomPerimeter}";

                Console.WriteLine(Area);
                Console.WriteLine(Perimeter);


                //Do you want to continue?
                Console.WriteLine("Continue? y/n: ");
                string continueAnswer = Console.ReadLine();

                char.TryParse(continueAnswer, out char contAnswer);

                if (contAnswer == 'y')
                {
                    ansYes = true;
                }
                else
                {
                    ansYes = false;
                }
            }
            while (ansYes == true);

         Console.WriteLine("Goodbye");
        }
    }
}
