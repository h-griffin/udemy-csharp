using System;
namespace Basics.ArraysAndLists
{
    class Arrays
    {
        static void Main(string[] args)
        {
            // array : fixed num of variables of same type

            // single dimension
            var SingleNumbers = new int[5] { 1,2,3,4,5 };

            // multidemensional / matrix arr

            // rectangular : new int[3, 5] -ONE BRACKET-
            var EmtpyMatrix = new int[3, 5];

            var InitializedMatrix = new int[3, 5]
            {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11,12,13,14,15 }
            };

            var element = EmtpyMatrix[0, 0];

            var colors = new int[3, 5, 4];


            // jagged : new int[3][] -TWO BRACKETS-
            //each arr different (array of arrays)
            var array = new int[3][];

            array[0] = new int[4];
            array[1] = new int[5];
            array[2] = new int[3];

            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("length" + numbers.Length);

            // indexOf()
            var index = Array.IndexOf(numbers, 9); 
            Console.WriteLine("index of 9: " + numbers.Length); //2

            // Clear()
            Array.Clear(numbers, 0, 2); //set first 2 to zero
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (var n in another)
            {
                Console.WriteLine(n); 
            }

            // Sort()
            Array.Sort(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Reverse()
            Array.Reverse(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }



        }
    }
}
