using System;
namespace Basics.Conditionals
{
    class RandomClass
    {
        static void Main(string[] args)
        {
            var random = new Random();


            for (var i=0 ; i<10 ; i++)
            {
                Console.Write((char)(random.Next(97, 122))); // ascii num a-z
            }

            // same code, alphabet length cast char
            for (var i = 0; i < 10; i++)
            {
                Console.Write((char)('a' + random.Next(0, 26))); 
            }


            // same code, save to string
            var buffer = new char[10];
            for (var i = 0; i < 10; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);



            // same code, cleaner
            const int passwordLength = 10;
            var bufferr = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
            {
                bufferr[i] = (char)('a' + random.Next(0, 26));
            }
        }
    }
}
