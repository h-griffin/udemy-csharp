using System;
namespace Basics.Text
{
    class Strings
    {
        static void Main(string[] args)
        {
            // Formatting
            // 
            // ToLower()  helloworld
            // ToUpper    HELLOWORLD

            // Trim()
            var fullname = "Haley Griffin ";
            Console.WriteLine("Trim: '{0}'", fullname.Trim());  // "Haley Griffin"

            Console.WriteLine("ToUpper: '{0}'", fullname.Trim().ToUpper()); // "HALEY GRIFFIN"


            // Searching
            //
            // indexOf('a')
            // LastIndexOf("Hello")
            var index = fullname.IndexOf(' ');


            // Substrings
            //
            // Substring(startIndex)
            // Substring(startIndex, length)
            var firstname = fullname.Substring(0, index);
            var lastname = fullname.Substring(index + 1);
            Console.WriteLine("Firstname: " + firstname);
            Console.WriteLine("Lastname: " + lastname);


            // Splitting
            //
            // str.Split(' ') 
            var names = fullname.Split(' '); //arr
            Console.WriteLine("Firstname: " + names[0]);
            Console.WriteLine("Firstname: " + names[1]);


            // Replacing
            //
            // Replace('a', '!')
            // Replace("Mosh", "Griffin")
            Console.WriteLine("Replace name: " + fullname.Replace("Haley", "Bryce"));


            // Null Checking
            //
            // String.IsNullOrEmpty(str)
            // String.IsNullOrWhiteSpace(str)
            if (String.IsNullOrWhiteSpace(fullname))
            {
                Console.WriteLine("invalid");
            }


            // Convert str to num
            var stringAge = "25";

            int i = int.Parse(stringAge);
                   // or..
            var IntAge = Convert.ToInt32(stringAge);

            // Convert num to str
            int k = 1234;

            string st = k.ToString();    // "1234"
            string t = k.ToString("C");  // "$1,234.00"  c = currency
            string t = k.ToString("C0"); // "$1,234"     no dicimal (c1 for1)




            
        }
    }
}
