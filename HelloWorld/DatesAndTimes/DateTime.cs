using System;
namespace Basics.DatesAndTimes
{
    class DateTime
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.hour);
            Console.WriteLine("Minute: " + now.minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongString());      // saturday, 23 may 2015
            Console.WriteLine(now.ToShortString());     // 23/05/2015
            Console.WriteLine(now.ToLongTimeString());  // 12:43:51 pm
            Console.WriteLine(now.ToShortTimeString()); // 12:43 pm

            Console.WriteLine(now.ToString()); // 23/05/2015 12:43:51 pm

            //format specifier
            Console.WriteLine(now.ToString("yy-MM-dd")); // 15-05/23
            Console.WriteLine(now.ToString("yyyy-MM-dd")); // 2015-05/23
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:MM")); // 2015-05/23 12:43 pm


        }
    }
}
