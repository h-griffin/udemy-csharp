using System;
namespace Basics.Conditionals
{
    class ForLoop
    {
        static void Main(string[] args)
        {
            // increment
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i); // 2 4 6 8 10
                }
            }

            // decrement
            for (var i = 1; i >=1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i); // 10 8 6 4 2
                }
            }




        }
    }
}
