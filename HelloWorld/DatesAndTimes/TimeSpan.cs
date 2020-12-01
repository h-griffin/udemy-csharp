using System;
namespace Basics.DatesAndTimes
{
    class TimeSpan
    {
        static void Main(string[] args)
        {
            // timespan is immutable
            // CREATING
            //                      hour, min, sec
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);

            var timeSpan1 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("duration: " + duration);

            // PROPERTIES : come in pairs
            
            Console.WriteLine("Minutes: " + timeSpan.Minutes); // 2
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); // 62.05

            // Add Subtract
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMintues(8))); // 1, 10, 3
            Console.WriteLine("Add Example: " + timeSpan.Subtract(TimeSpan.FromMintues(2))); // 1, 0, 3

            //ToString
            Console.WriteLine("ToString: " + timeSpan.ToString()); // console defaults tp string

            // Parse (from string)
            Console.WriteLine("Parse: " + timeSpan.Parse("01:02:02")); // 01:02:03
        }
    }
}
