using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_C_Sharp_Tasks.Task16
{
    internal class Delegates
    {

        public delegate void Bankdel(string bankname, double P, int T, float R);
        public void GetBankDetails1(string bankname, double P, int T, float R)
        {
            
            Console.WriteLine("Bank Name: "+ bankname);
            Console.WriteLine("Interest rate: "+ ((int)(P * T * R) / 100));
            Console.WriteLine("-----------------------------------------");
        }
        public void GetBankDetails2(string bankname, double P, int T, float R)
        {

            Console.WriteLine("Bank Name: " + bankname);
            Console.WriteLine("Interest rate: " + (P * T * R) / 100);
            Console.WriteLine("-----------------------------------------");
        }
        public void GetBankDetails3(string bankname, double P, int T, float R)
        {

            Console.WriteLine("Bank Name: " + bankname);
            Console.WriteLine("Interest rate: " + (P * T * R) / 100);
            Console.WriteLine("-----------------------------------------");
        }
        public void GetBankDetails4(string bankname, double P, int T, float R)
        {

            Console.WriteLine("Bank Name: " + bankname);
            Console.WriteLine("Interest rate: " + (P * T * R) / 100);
            Console.WriteLine("-----------------------------------------");
        }
        public void GetBankDetails5(string bankname, double P, int T, float R)
        {

            Console.WriteLine("Bank Name: " + bankname);
            Console.WriteLine("Interest rate: " +((int) (P * T * R) / 100));
            Console.WriteLine("-----------------------------------------");
        }

        public static void Main(string[] args)
        {
            Delegates d = new Delegates();
           /* //single-cast delegate
            Bankdel bank = d.GetBankDetails1;
            bank("SBI", 4000, 3, 2.7f);
            bank = d.GetBankDetails2;
            bank("Axis", 5000, 2, 3.0f);*/

            //multicast delegates
            Console.WriteLine("--------Multuicast Delegates------------------");

            Bankdel bank_SI = d.GetBankDetails1;

            bank_SI += d.GetBankDetails2;
            Console.WriteLine("Bank 1 and Interest");
            d.GetBankDetails1("SBI Bank", 4000, 3, 2.7f);


            Console.WriteLine("Bank 2 and Interest ");
            bank_SI -= d.GetBankDetails2;
            d.GetBankDetails2("HDFC Bank", 4000, 3, 3.25f);

            Console.WriteLine("Bank 3 and Interest ");
            bank_SI -= d.GetBankDetails3;
            d.GetBankDetails3("Kotak Mahindra Bank", 4000, 3, 3.50f);

            Console.WriteLine("Bank 4 and Interest ");
            bank_SI -= d.GetBankDetails4;
            d.GetBankDetails4("Axis Bank", 4000, 3, 3.0f);

            Console.WriteLine("Bank 5 and Interest ");
            bank_SI -= d.GetBankDetails5;
            d.GetBankDetails5("ICICI", 4000, 3, 3.35f);




        }
    }
}
