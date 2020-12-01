using System;
using System.Text;      // <<<<<
namespace Basics.Text
{
    public class StringBuilder
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");

            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            //chainable
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);


            builder.Replace('-', '+');
            builder.Remove(0, 10); //remove 10 from start
            builder.Insert(0, new string('-', 10));


            Console.WriteLine(builder);

            Console.WriteLine(builder[0]); //indexing still available
        }
    }
}
