using System;

namespace Lab11
{
    public class Animated : IMovie
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public void Genre()
        {
            Console.WriteLine("Frozen");
            Console.WriteLine("Little Mermaid");
            Console.WriteLine("Up");
        }

    }
}
//using System;
//using August6thExamples.Enums;

//namespace August6thExamples.Cars
//{
//    public class Rickshaw : IAutomobile
//    {
//        public int Mileage { get; set; }
//        public CarType Type { get; set; }

//        public void VroomVroom()
//        {
//            Console.WriteLine("I go vroom vroom not so loud");
//        }
//    }
//}