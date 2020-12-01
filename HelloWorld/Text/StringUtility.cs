using System;
using System.Collections.Generic;
namespace Basics.Text
{
    public class StringUtility
    {
        public static string SummerizeText(string text, int maxLength = 20)
        {


            //const int maxLength = 20;

            // check if length is below thres if not summarize

            if (text.Length < maxLength)
                //Console.WriteLine(text);
                return text;


            //sentence.Substring(0, maxLength); // could cut off mid word
            var words = text.Split(" ");
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                {
                    break;
                }
            }

            var summary = String.Join(" ", summaryWords) + "...";
            //Console.WriteLine(summary);
            return summary;



        }
    }
}
