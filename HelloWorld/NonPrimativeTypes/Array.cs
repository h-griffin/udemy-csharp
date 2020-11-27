using System;
namespace HelloWorld.NonPrimativeTypes
{
    public class Array
    {
        public Array()
        {
            // collection of variables of the same type
            int number1;
            int number2;
            int number3;

            //                      V size
            int[] numbers = new int[3]; // must specify how big the array is allocate memory

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            // if you know the values in array
            var moreNumbers = new int[3] {1,2,3};

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]); //true
            Console.WriteLine(flags[1]); //false
            Console.WriteLine(flags[2]); //false

            var names = new string[3] { "jack", "john", "mary" };
        }
    }
}
