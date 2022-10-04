using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_C_Sharp_Tasks.Task17
{
    internal class CountLines_File
    {
        public static void Main()
        {
            //set count 0 to count the lines in the file
            int count = 0;
            foreach (string line in File.ReadLines(@"C:\Users\EI13146\Desktop\.net\C_Sharp Files Concept\T17_Files1.txt"))
            {
                Console.WriteLine(line);
                count++;// increment the number of count
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("There are {0} Lines in the File",count);
        }
    }
}
