using System;
namespace Basics.ProceduralProgramming
{
    public class CleanCode
    {
        //  responsibel for console communication 
        static void Main(string[] args)
        {
            Console.WriteLine("Whats you're name? ");
            var name = Console.ReadLine();


            var reversed = ReverseName(name);
            Console.WriteLine("reversed name; " + reversed);

        }

        // responsible for logic 
        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }
            var reversed = new string(array);

            return reversed;
        }
    }
}
