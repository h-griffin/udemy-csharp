using System;
namespace Basics.NonPrimativeTypes
{
    public enum ShippingMethod //new type = namespace level
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3,

        // use for number of related constants
        // enums are internally integers
        // like dict or obj

        //if no value given default first is 0 and icrements by 1
    }

    class Enums
    {
        static void Main(string[] args)
        {
            // messy -not used
            const int RegularAirMail = 1;
            const int RegisteredAirMail = 2;
            const int Express = 3;

            //use with dot notation
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); //enum is int


            var methodId = 3; //receive num 3
            Console.WriteLine((ShippingMethod)methodId); //convert to shipping method

            Console.WriteLine(method.ToString()); // enum to string (writeline auto strings)


            var methodName = "Express"; //parse string to shipping method
            // parsing : string convert to different type

            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName); //string to enum (returns obj, must cast and store)

        }
    }
}
