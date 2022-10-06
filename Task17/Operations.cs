using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_C_Sharp_Tasks.Task17
{
    internal class Operations
    {
        public static void Main()
        {
            //Move
            //File.Move(@"C:\Users\EI13146\Desktop\.net\C_Sharp Files Concept\Files5.txt", @"C:\Users\EI13146\Desktop\.net\C_Sharp Files Concept\File_Move.txt");

            //Copy
            /* string source_path = @"C:\Users\EI13146\Desktop\.net\C_Sharp Files Concept\Files4.txt";
             string dest_path = @"C:\Users\EI13146\Desktop\.net\Files6.txt";
             File.Copy(source_path, dest_path);*/

            //Delete
            string path = @"C:\Users\EI13146\Desktop\Files1.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
                try
                {
                    File.Delete(path);
                }
                catch
                {
                    Console.WriteLine("File Cannot be Deleted");
                }
            }
            else
            {
                Console.WriteLine("File does not Exist");
            }


        }
    }
}
