using System;
using System.IO; // <<<<<<

namespace Basics.WorkingWithFiles
{
    public class FileandFileInfo
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";


            // FILE STATIC : security check each call

            //          what                ,where                  , override if exists
            File.Copy(@"c:\temo\myfile.jpg", @"d:\temp\myfile.jpg", true);

            File.Delete(path);

            if (File.Exists(path)) // returns bool
            {
                //
            }

            var content = File.ReadAllText(path); // returns byte array / string


            // FILEINFO INSTANCE : one security check on load
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");

            fileInfo.Delete();

            if (fileInfo.Exists) // ATTRIBUTE NOT METHOD
            {
                // 
            }

            
        }
    }
}
