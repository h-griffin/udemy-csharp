using System;
namespace HelloWorld.ReferenceValueTypes
{

    public class Person
    {
        public int Age;
    }

    class RefValDemo
    {
        // static, call without creating obj
        static void Main(string[] args)
        {
            // value type
            var number = 1;
            Increment(number); // val still 1 - value type copy - out of scope of main - increment method executes then destroys immediatly
            Console.WriteLine(number); //1

            // reference type
            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age); //30

        }

        public static void Increment(int number)
        {
            number += 10;
        }

        static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
    
}
