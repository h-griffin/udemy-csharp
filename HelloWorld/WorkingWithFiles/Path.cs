using System;
using System.IO; // <<<<

namespace Basics.WorkingWithFiles
{
    public class Path
    {
        static void Main(string[] args)
        {

            var path = @"c:\projects\charpfundamentals\helloworld\helloworld.sln";

            // want to extranct .sln
            // manual > poor
            var dotindex = path.IndexOf('.');
            var extension = path.Substring(dotindex);

            Console.WriteLine("extension: " + Path.GetExtension(path));
            Console.WriteLine("file name: " + Path.GetFileName(path));
            Console.WriteLine("filename wihtout extension : " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("directory name: " + Path.GetDirectoryName(path));
        }
    }
}
