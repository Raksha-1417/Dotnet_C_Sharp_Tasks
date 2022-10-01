using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_C_Sharp_Tasks.Task14
{
    internal class Constructor_OverLoading
    {
        public class add
        {
            public add(int a, int b) {
                int c = a + b;
                Console.WriteLine("The addition of a and b "+c);
                }
            public add(float a, float b)
            {
                float c = a + b;
                Console.WriteLine("The addition of a and b " + c);
            }
            public add(string  a, string b)
            {
                string c = a + b;
                Console.WriteLine("The addition of a and b " + c);
            }
        }
        public static void Main()
        {
            add ad = new add(30, 80);
            add addfloat = new add(45.6f, 8.6f);
            add addstring = new add("Web", " Development");

        }
    }
}
