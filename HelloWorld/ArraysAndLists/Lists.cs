using System;
using System.Collections.Generic; // <<<<<<<<< 
namespace Basics.ArraysAndLists
{
    class Lists
    {
        static void Main(string[] args)
        {
            // array : fixed size
            // list: dynamic size

            var numbers = new List<int>() { 1, 2, 3, 4 };

            // Add()
            numbers.Add(1);

            // AddRange()
            numbers.AddRange(new int[3] { 5, 6, 7 });
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // IndexOf() LastIndexOf()
            Console.WriteLine("index of 1:  " + numbers.IndexOf(1)); // 0
            Console.WriteLine("index of 1:  " + numbers.LastIndexOf(1)); // 4

            // Count
            Console.WriteLine("count:  " + numbers.Count);

            // Remove()
            numbers.Remove(1);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //foreach (var number in numbers) // cannot modify in foreach
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
                Console.WriteLine(numbers[i]);
            }

            // Clear()
            numbers.Clear();
            Console.WriteLine("count:  " + numbers.Count); //0

        }
    }
}
