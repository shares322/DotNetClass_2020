using System;

namespace Lab11
{
    public class SciFi : IMovie
    {
        public string Title {get; set;}
        public string Category {get; set;}
        public void Genre()
        {
            Console.WriteLine("Star Wars");
            Console.WriteLine("The Invisible Man");
        }
    
    }
}