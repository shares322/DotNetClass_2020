using System;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 100 movies in this list.");
            Console.WriteLine();
            Console.WriteLine("What category are you interested in?: ");

            var userInput = Console.ReadLine();

            var isMovieList = Enum.TryParse(userInput, out MovieCategoryList movieCategoryList);
            if (isMovieList)
            {
                IMovie movie;

                switch (movieCategoryList)
                {
                    case MovieCategoryList.Animated:
                        Console.WriteLine("You entered an Animated movie.");
                        movie = new Animated();
                        movie.Genre();
                        break;
                    case MovieCategoryList.Drama:
                        Console.WriteLine("You entered a Drama movie.");
                        movie = new Drama();
                        movie.Genre();
                        break;
                    case MovieCategoryList.Horror:
                        Console.WriteLine("You entered a Horror movie.");
                        movie = new Horror();
                        movie.Genre();
                        break;
                    case MovieCategoryList.SciFi:
                        Console.WriteLine("You entered a SciFie movie.");
                        movie = new SciFi();
                        movie.Genre();
                        break;
                    default:
                        break;
                }
            } else if (!isMovieList)
                {
                Console.WriteLine("Please enter in correct type of movie.");
            }
        }
    }        
}

