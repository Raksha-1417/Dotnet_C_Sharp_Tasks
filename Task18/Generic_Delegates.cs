using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_C_Sharp_Tasks.Task18
{
    internal class Generic_Delegates
    {
        public delegate T Calculate<T>(T r);
        class Operations
        {
            public int AreaSquare(int a)
            {
                return a * a;
            }
            public double AreaSquare(double a)
            {
                return a * a;
            }
            public int AreaCube(int b)
            {
                return 6* b * b;
            }
            public double AreaCube(double b)
            {
                return 6 * b * b;
            }
            public int AreaCircle(int r)
            {
                return (int) 3.142 * r * r;
            }

            public double AreaCircle(double r)
            {
                return 3.142 * r * r;
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("--------------Generic Delegate of Area of Shapes----------------------------");
                Operations o=new Operations();
                Console.WriteLine("---------------------------Area Value in int--------------------------------");
                //Instantiate delegate with AreaSquare Method using int datatype
                Calculate<int> dl = new Calculate<int>(o.AreaSquare);
                Console.WriteLine("Area of Square " + dl(4));
                //Instantiate delegate with AreaCube Method using int datatype
                dl = o.AreaCube;
                Console.WriteLine("Area of Cube " + dl(3));
                //Instantiate delegate with AreaCircle Method using int datatype
                dl = o.AreaCircle;
                Console.WriteLine("Area of Circle " + dl(8));

                Console.WriteLine("---------------------------Area Value in double--------------------------------");
                //Instantiate delegate with AreaSquare Method using double datatype
                Calculate<double> dl1 = new Calculate<double>(o.AreaSquare);
                Console.WriteLine("Area of Square " + dl1(4.6));
                //Instantiate delegate with AreaCube Method using double datatype
                dl1 = o.AreaCube;
                Console.WriteLine("Area of Cube " + dl1(3.8));
                //Instantiate delegate with AreaCircle Method using double datatype
                dl1 = o.AreaCircle;
                Console.WriteLine("Area of Circle " + dl1(8.4));
                Console.ReadLine();



            }
        }
    }
}
