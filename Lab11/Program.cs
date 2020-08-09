using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ansYes = true;
            var animatedMovieList = new List<Animated>()
            {
                new Animated("Frozen"),
                new Animated("Up"),
                new Animated("Little Mermaid"),
            };
            var dramaMovieList = new List<Drama>()
            {
                new Drama("Yellowstone"),
                new Drama("Ozark"),
            };
            var horrorMovieList = new List<Horror>()
            {
                new Horror("The Shining"),
                new Horror("Come to Daddy"),
                new Horror("The Invisible Man"),
                
            };
            var scifiMovieList = new List<SciFi>()
            {
                new SciFi("Star Wars"),
                new SciFi("Star Trek"),
            };


            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 100 movies in this list.");
            Console.WriteLine();
            do
            {
                Console.WriteLine("What category are you interested in? Animated, Drama, Horror, or SciFi?: ");

                var userInput = Console.ReadLine();

                var isMovieList = Enum.TryParse(userInput, out MovieCategoryList movieCategoryList);
                if (isMovieList)
                {
                    IMovie movie;

                    switch (movieCategoryList)
                    {
                        case MovieCategoryList.Animated:
                            Console.WriteLine("You entered the Animated movie category. The list of movies are: ");
                            foreach (var animatedMovie in animatedMovieList)
                            {
                                Console.WriteLine(animatedMovie.Title);
                            }
                            break;
                        case MovieCategoryList.Drama:
                            Console.WriteLine("You entered the Drama movie category. The list of movies are: ");
                            foreach (var dramaMovie in dramaMovieList)
                            {
                                Console.WriteLine(dramaMovie.Title);
                            }
                            break;
                        case MovieCategoryList.Horror:
                            Console.WriteLine("You entered the Horror movie category. The list of movies are: ");
                            foreach (var horrorMovie in horrorMovieList)
                            {
                                Console.WriteLine(horrorMovie.Title);
                            }
                            break;
                        case MovieCategoryList.SciFi:
                            Console.WriteLine("You entered the SciFi movie category. The list of movies are: ");
                            foreach (var scifiMovie in scifiMovieList)
                            {
                                Console.WriteLine(scifiMovie.Title);
                            }
                            break;
                        default:
                            break;
                    }
                }
                else if (!isMovieList)
                {
                    Console.WriteLine("You entered in an incorrect movie type.");
                }
            
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
                
            } while (ansYes == true);

            Console.WriteLine("Thanks for playing! Good-bye!");
        }
    }        
}

