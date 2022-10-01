using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dotnet_C_Sharp_Tasks.Task14
{
    internal class Regex_Mobile
    {
        public static void mobile()
        {
            Console.WriteLine("Mobile-Validation");
            string mobile;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter the Mobile Number");
                mobile = Console.ReadLine();
                var validate_mobile = Regex.IsMatch(mobile, @"(0|91)?[7-9][0-9]{9}");
                Console.WriteLine(validate_mobile);
            }
        }
        public static void Main()
        {
            mobile();
        }
    }
}
