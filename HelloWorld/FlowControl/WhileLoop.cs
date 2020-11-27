using System;
namespace Basics.Conditionals
{
    public class WhileLoop
    {
        static void Main(string[] args)
        {
            // print nums divisible by 2
            var i = 0;
            while (i <= 10)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);

                    i++;
                }
            }


            // repeat input, exit if none
            while (true)
            {
                Console.Write("type your name :  ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@echo: " + input);
                    continue; // line 21
                }

                break;
            }
        }
    }
}
