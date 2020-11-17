using System;
namespace HelloWorld.Math // project > folder
{
    public class Calculator
    {
        //public int Add(int a, int b)
        public static int Add(int a, int b) // static modifier
        {
            return a + b;
        }

        //int result = Calculator.Add(1, 2); // do not need new obj for static modifier inside class
    }
}
