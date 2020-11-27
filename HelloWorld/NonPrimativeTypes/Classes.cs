using System;

using Basics.Math;

namespace HelloWorld.NonPrimativeTypes
{
    

    class Program
    {
        static void ClassesMain(string[] args) // static means there is one instance
        {
            // object is instance of class
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }

    

        


    
}