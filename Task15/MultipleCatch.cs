using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_C_Sharp_Tasks.Task15
{
    public class Catch_Demo
    {
       
        public void M_catch()
        {
          try{
		   
		   int[] arr = { 1, 2, 3, 4 };
           Console.WriteLine("Value ="+arr[5]);   
                
           } 
            catch(IndexOutOfRangeException ex)
            {

               
                Console.WriteLine(ex.Message);
              
            }
            catch(ArrayTypeMismatchException ex)
            {
                Console.WriteLine("An Array Mismatch caught");

            }
            catch(Exception ex)
            {
                Console.WriteLine("An Exception is caught");

            }
        }
        public void Multiple()
        {
            int [] x = { 8, 17, 28, 34,89 };
            int[] y = { 2, 0, 0, 7 };
            for (int j = 0; j < x.Length; j++)
            {
                try
                {
                    Console.WriteLine("Number: " + x[j]);
                    Console.WriteLine("Divisor: " + y[j]);
                    Console.WriteLine("Quotient: " + x[j] / y[j]);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);


                }
            }
            


        }



}

    internal class MultipleCatch
    {
        public static void Main()
        {
            Catch_Demo c = new Catch_Demo();
            Console.WriteLine("-----------------Multiple Catch 1--------------------------");
            c.M_catch();
            Console.WriteLine("-----------------Multiple Catch 2--------------------------");
            c.Multiple();
           


        }
    }
}

