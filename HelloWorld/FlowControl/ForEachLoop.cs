using System;
namespace Basics.Conditionals
{
    class ForEachLoop
    {
        static void Main(string[] args)
        {
            var name = "John Smith";
            //enumerable obj > string

            for (var i = 0; i < name.Length; i ++)
            {
                Console.WriteLine(name[i]);
            }

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }


            var numbers = new int[] { 1, 2, 3, 4 };
            //enumerable obj > array

            foreach ( var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
