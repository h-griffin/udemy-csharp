using System;

namespace Operators
{
    class Operators
    {
        static void thirdMain(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(a / b);
            Console.WriteLine((float)a / (float)b);

            Console.WriteLine(a + b * c);

        }
    }
}

