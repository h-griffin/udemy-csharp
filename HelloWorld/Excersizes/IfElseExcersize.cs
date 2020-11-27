using System;
namespace Basics.Excersizes
{
    public class IfElseExcersize
    {
        static void Main(string[] args)
        {
            //  Console.ReadLine for user input

            // display valid if 1-10
            var UserNumber = 3;

            if (UserNumber >= 1 && UserNumber <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            // take 2 num from console display greater
            var firstNum = 1;
            var secondNum = 2;

            if (firstNum > secondNum)
            {
                Console.WriteLine(firstNum);
            }
            else
            {
                Console.WriteLine(secondNum);
            }

            // enter width height, return if landscape or portrait
            var width = 10;
            var height = 5;

            if (width > height)
            {
                Console.WriteLine("Landscape");
            }
            else
            {
                Console.WriteLine("Portrait");
            }


        }
    }
}
