using System;
namespace Basics.Conditionals
{

    public enum Season 
    {
        Spring,
        Summer,
        Autmn,
        Winter,
    }

    class SwitchCase
    {
        static void Main(string[] args)
        {
            var season = Season.Autmn;

            switch (season)
            {
                case Season.Autmn:
                    Console.WriteLine("its autmn");
                    break;
                case Season.Summer:
                    Console.WriteLine("its summer");
                    break;
                // share code blocks
                case Season.Spring: // <<<
                case Season.Winter: // <<< 
                    Console.WriteLine("its spring or winter");
                    break;
                default:
                    Console.WriteLine("not a season");
                    break;

            }
        }
    }
}
