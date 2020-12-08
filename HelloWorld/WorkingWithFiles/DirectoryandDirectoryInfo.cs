using System; 
using System.IO; // <<<<<<
namespace Basics.WorkingWithFiles
{
    public class DirectoryandDirectoryInfo
    {
        static void Main(string[] args)
        {
            // DIRECTORY : STATIC
            Directory.CreateDirectory(@"c:temp\folder1");

            //                  where                                    all files  
            var files = Directory.GetFiles(@"c:\projects\charpfundamentals", "*", SearchOption.AllDirectories); // returns strign

            foreach(var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"c:\projects\charpfundamentals", "*.*", SearchOption.AllDirectories);
            foreach(var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("path");

            // DIRECTORY INFO

            var directoryInfo = new DirectoryInfo("path");

            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
}
