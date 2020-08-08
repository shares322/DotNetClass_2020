using System;


namespace Lab11
{
    public class Horror : IMovie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public void Genre()
        {
            Console.WriteLine("The Shining");
            Console.WriteLine("Come to Daddy");
        }
    }
}
