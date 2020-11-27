using System;
namespace HelloWorld.NonPrimativeTypes
{
    public class String
    {
        public String()
        {
            // sequence of chars inside "double quote"
            // chars 'single'

            // default same
            Int32 i;
            int j; 

            // var
            string firstName = "Haley";
            string lastName = "Griffin";

            string concatName = firstName + " " + lastName;
            string formatName = string.Format("my name is {0} {1}", firstName, lastName);
            Console.WriteLine(concatName, formatName);

            var names = new string[3] { "jack", "john", "mary" };
            var formatedNames = string.Join(",", names);
            Console.WriteLine(formatedNames);

            var numbers = new int[3] { 1, 2, 3 };
            string list = string.Join(",", numbers);
            Console.WriteLine(list);

            string name = "griffin";
            char firstChar = name[0]; // g
            Console.WriteLine(firstChar);

            // strings are immutable when created they cannot be changed, must use methods(new string)

            // ESCAPED CHARACTERS
            // \n new line
            // \t tab
            // \\ backslach char
            // \' singel quote
            // \" double quote

            // VERBATIM STRING : ignore escaped chars
            string BasicPath = "c:\\projects\\project1\\folder1";
            string VerbatimPath = @"c:\projects\project1\folder1";

            
        }
    }
}
