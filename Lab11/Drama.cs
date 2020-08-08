using System;

namespace Lab11
{
    public class Drama : IMovie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public void Genre()
        {
            Console.WriteLine("The Invisible Man");
            Console.WriteLine("Ozark");
        }

    }
}