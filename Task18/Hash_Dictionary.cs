using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dotnet_C_Sharp_Tasks.Task18
{
    internal class Hash_Dictionary
    {
        public static void Dictionary_Demo()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Angular");
            dic.Add(2, "React JS");
            dic.Add(3, "Vue JS");
            dic.Add(4, "Kotlin ");
            Console.WriteLine("******************THIS IS DICTIONARY**********************");


            foreach ( var i in dic)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"key:{dic[1]}");
           // Console.WriteLine($"key:{dic[5]}");

        }
        public static void HashTable_Demo()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "PHP");
            ht.Add(2, 45);
            ht.Add(3, "Node JS");
            ht.Add(4, "Spring Boot");
            ht.Add(5, "Django");
         

            Console.WriteLine("******************THIS IS HASHTABLE**********************");
            ICollection key = ht.Keys;
            foreach (var i in key)
            {
                Console.WriteLine(ht[i]);
            }
            Console.WriteLine($"key:{ht[1]}");
            Console.WriteLine($"key:{ht[5]}");
            Console.WriteLine($"key:{ht[6]}");// Null Value because no such index 6

        }
        public static void Main()
        {
            Dictionary_Demo();
            HashTable_Demo();

        }
    }
}
