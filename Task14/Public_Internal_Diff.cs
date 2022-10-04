using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_C_Sharp_Tasks.Task14
{
    //internal class Public_Internal_Diff - replaced with public so to access the classes in other projects
 public class Public_Internal_Diff
    {
        public int age;
        public string name;
        //can access only within the class
      
        public void EmpDetails(int d_age, string d_name)
        {
            age = d_age;
            name = d_name;
            if (d_age < 18)
            {
                Console.WriteLine("You are not eligible for Driving License");
            }
            else
            {
                Console.WriteLine("You can get Driving License");
            }
            Console.WriteLine($"{age}:{name}");

        }
    }
    public class Public_Main
    {
        public static void Main()
        {
            Public_Internal_Diff p = new Public_Internal_Diff();
            p.EmpDetails(18, "Ananya");
            //p.DL = 17;//inaccessible outside the clas
            //Console.WriteLine(p.DL);//inaccessible outside the class

        }
    }
}
