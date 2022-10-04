using Dotnet_C_Sharp_Tasks.Task14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_C_Sharp_Tasks.Task17
{
    public class file_table
    {
        public void write()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13146\Desktop\.net\C_Sharp Files Concept\T17_Files1.txt");
            FileStream fs = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            try
            {
                sw.WriteLine("Multiplication Tables from 1 to 10");

            }catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }
        public void append()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13146\Desktop\.net\C_Sharp Files Concept\T17_Files1.txt");
            FileStream fs= fileInfo.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw= new StreamWriter(fs);
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    sw.WriteLine("Multiplication Table of " + i);
                    for (int j = 1; j <= 10; j++)
                    {
                        sw.WriteLine("{0} X {1}= {2} \n", i, j, i * j);

                    }
                }

            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }
        public void read()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13146\Desktop\.net\C_Sharp Files Concept\T17_Files1.txt");
            FileStream fs = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader reader= new StreamReader(fs);
            try
            {
                string multi_table=reader.ReadToEnd();
                Console.WriteLine(multi_table);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                reader.Close();
                fs.Close();
            }
        }
    }
    internal class Files_Tables
    {
        public static void Main()
        {
            file_table ft = new file_table();
            ft.write();
            ft.read();
            ft.append();
            ft.read();
        }
    }
}
