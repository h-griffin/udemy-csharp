using System;
namespace Basics.Conditionals
{
    public class IfElse
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("its morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("its afternoon");
            }
            else
            {
                Console.WriteLine("its evening");
            }


            // Turnary if else
            bool isGoldCustomer = true;

            float price;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }

            // turnary                        if       else
            float TurnPrice = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);
        }
    }
}
