using System;

namespace DotNetClass_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ansYes = true;
            Console.WriteLine("Hi, What is your name? ");
            var inputName = Console.ReadLine();

            do
            {

                Console.WriteLine(inputName + ", Enter a number between 1 and 100: ");
                var userInput = Console.ReadLine();
                var userInputNum = int.TryParse(userInput, out int userInputNumber);

                // Your number is odd
                if (userInputNumber % 2 == 1 && userInputNumber >= 1 && userInputNumber <= 100)
                {
                    Console.WriteLine("Your number is " + userInputNumber + " and is Odd");
                }
                // Inclusive 2 to 25 and even
                else if (userInputNumber >= 2 && userInputNumber <= 25 && userInputNumber % 2 == 0)
                {
                    Console.WriteLine("Your number is Even and less than 25");
                }
                // Inclusive 26 to 60 and even
                else if (userInputNumber >= 26 && userInputNumber <= 60 && userInputNumber % 2 == 0)
                {
                    Console.WriteLine("Your number is Even");
                }
                // Greater than 60 and even
                else if (userInputNumber > 60 && userInputNumber <= 100 && userInputNumber % 2 == 0)
                {
                    Console.WriteLine("Your number is " + userInputNumber + " and is Even");
                }
                // Greater than 60 and odd
                else if (userInputNumber > 60 && userInputNumber <= 100 && userInputNumber % 2 == 1)
                {
                    Console.WriteLine("Your number is " + userInputNumber + " and is Odd");
                }
                // outside of 1 or 100
                else if (userInputNumber < 1 || userInputNumber > 100)
                {
                    Console.WriteLine(inputName + ", You need to enter a number between 1 and 100: ");
                }
                else
                {
                    Console.WriteLine("Please try again.");
                }

                // Continue question
                Console.WriteLine("Would you like to continue? y/n: ");
                string continueAnswer = Console.ReadLine();

                char.TryParse(continueAnswer, out char contAnswer);

                if (contAnswer == 'y' || contAnswer == 'Y')
                {
                    ansYes = true;
                }
                else
                {
                    ansYes = false;
                }
            }
            while (ansYes == true);

            Console.WriteLine("Good-bye");
        }
    }
}