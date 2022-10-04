using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_C_Sharp_Tasks.Task17
{
    internal class FirstLine
    {
        public static void Main()
        {
            string path = @"C:\Users\EI13146\Desktop\.net\C_Sharp Files Concept\T17_Files3.txt";
            //Exists
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File does not Exist");
            }
            Console.WriteLine("-----------------------------------------");
            /// <summary>
            /// Read the firstline of the content
            /// </summary>

            string[] content;
            content = File.ReadAllLines(path);
            Console.WriteLine(content[0]);
        }

    }
}
