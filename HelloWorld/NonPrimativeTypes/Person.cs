using System;

namespace Basics.NonPrimativeTypes
{
    // one class per file
    public class Person
    {
        public string FirstName;
        public string LastName;

        // method (void return type = no return values)
        public void Introduce()
        {
            Console.WriteLine("hi my name is " + FirstName + ' ' + LastName);
        }

        // object/instance : declare type and identifier +allocate memory for obj >'new'


        //Person person = new Person(); //obj
        ////var person = new Person();

        //Person.Name = "Griffin";
        //Person.Introduce();
    }
}
