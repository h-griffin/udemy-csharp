using System;

namespace Basics.PrimativeTypes
{
    class Operators
    {
        static void OperatorsMain(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(a / b);
            Console.WriteLine((float)a / (float)b);

            Console.WriteLine(a + b * c); // 9
            Console.WriteLine(a != b); // bool

            
        }
    }
}

