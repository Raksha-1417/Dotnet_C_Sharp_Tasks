using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_C_Sharp_Tasks.Task15
{
    public class ValidateAgeException : Exception
    {
        public ValidateAgeException(string message) : base(message)
        {

        }
    }
    internal class ValidateAge
    {
        public static void Main()
        {
            int age;
            try {
                Console.WriteLine("Enter the age");
                age = Convert.ToInt32(Console.ReadLine());
                if(age<22)
                {
                    throw (new ValidateAgeException("Your Age is less than 22"));
                }
                else
                {
                    Console.WriteLine("Your age is greater than 22 ");
                }


            }catch(ValidateAgeException e)
            {
                Console.WriteLine(e.Message);
            }
            }
    }
}
