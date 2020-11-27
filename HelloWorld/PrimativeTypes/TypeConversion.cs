using System;

namespace Basics.PrimativeTypes
{
    class TypeConversion
    {
        static void TypeConversionMain(string[] args)
        {
            // IMPLICIT 
            byte b = 1; //1byte
            int i = b;  //4bytes    no data loss
            Console.WriteLine(i);

            // EXPLICIT     
            int j = 1;           // 1 small enough no data loss
            byte c = (byte)j;    // must cast
            Console.WriteLine(b);

            int num = 1000;
            byte bt = (byte)num;    // max 255 (not 1000)
            Console.WriteLine(bt);  // 232 (data loss)

            // COMPATIBLE TYPES
            try
            {
                var number = "1234";
                //int intiger = (int)number; // cannot cast
                //int intiger = Convert.ToInt32(number);
                int intiger = Convert.ToByte(number);
                Console.WriteLine(i);
            }
            catch (Exception)
            {
                // prevents crashing > must handle exceptions
                Console.WriteLine("the number could not be converted to a byte");
            }

            try
            {
                string str = "true";
                bool bl = Convert.ToBoolean(str);
                Console.WriteLine(bl);
            }
            catch
            {
                Console.WriteLine("tring type could not convert to bool type");
            }

        }
    }
}