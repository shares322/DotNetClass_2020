using System;
using System.Collections.Generic;

namespace MockAssessment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] characterArray = new string[] { "Name1", "Shari", "Sid", "Yoda", "Taylore" };
            //AddStarWarsCharacters(characterArray);
            Console.WriteLine(AddStarWarsCharacters(characterArray));
        }
        public static int AddStarWarsCharacters(string[] characterArray)
        {
            for (int i = 0; i < characterArray.Length; i++)
            {
                if (characterArray[i] == "Yoda") return i;
            }
            return 0;
        }

        public static string DeathStarCombat(Dictionary<string, int> jediName)
        {
            int max = 0;
            string maxName = "";
            foreach (var name in jediName)
            {
                if (name.Value > max)
                {
                    max = name.Value;
                    maxName = name.Key;
                }

            }
            return maxName;
        }

        public static List<string> ConvertPlanets(string[] planetArray)
        {
            var planetList = new List<string>();
            for (int i = 0; i < planetArray.Length; i++)
            {
                planetList.Add(planetArray[i]);
            }
            planetList.Reverse();
            return planetList;
        }

        public static double AverageDroids(List<int> droidList)
        {
            double sum = 0;
            double totalDroids = 0;
            foreach (var droid in droidList)
            {
                if (droid % 2 == 0)
                {
                    sum += droid;
                    totalDroids++;
                }
            }
            return sum / totalDroids;
        }

        public static string TryToCatchDarthVader(string userInput)
        {
            try
            {
                int.Parse(userInput);
                return "Vader Was Captured!";
            }
            catch (Exception)
            {
                return "Vader Got Away!";
                throw;
            }
        }
    }
}

