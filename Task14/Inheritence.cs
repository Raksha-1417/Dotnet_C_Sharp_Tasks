using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_C_Sharp_Tasks.Task14
{
    public class Bonus
    {
       
        protected int bonus;
        protected string empname;
        protected int empid;
        protected int salary;
     

    }
    public class Staff : Bonus
    {
       

        public void Staff_SalaryBonus()
        {
            Console.WriteLine("--------------STAFF------------------");
            Console.WriteLine("Enter the Employee Name");
           empname = Console.ReadLine();
            Console.WriteLine("Enter the Employee No");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Salary");
            salary = Convert.ToInt32(Console.ReadLine());
            bonus = 3 * salary; 
            Console.WriteLine($"Staff: Salary After Bonus:{bonus}");

        }
    }
    public class NonStaff : Staff
    {
      
        public void NonStaff_bonus()
        {
            Console.WriteLine("-------NON-STAFF------------------");
            Console.WriteLine("Enter the Employee Name");
            empname = Console.ReadLine();
            Console.WriteLine("Enter the Employee No");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Salary");
            salary = Convert.ToInt32(Console.ReadLine());


            bonus = 2 * salary;
            Console.WriteLine($"Non Staff: Salary after Bonus= {bonus}");
        }
    }
    internal class Inheritence
    {
        public static void Main()
        {
           
           
          
            Staff s = new Staff();
            s.Staff_SalaryBonus();
            NonStaff n1 = new NonStaff();
          
            NonStaff n =new NonStaff();
            n.NonStaff_bonus();
           
        }


    }
}
