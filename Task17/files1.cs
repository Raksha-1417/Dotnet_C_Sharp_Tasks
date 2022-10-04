using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_C_Sharp_Tasks.Task17
{
    public class Files_Demo
    {
        /// <summary>
        /// Write contents into the file using StreamWriter class
        /// </summary>
        public void Write()
        {
            //Specify the filename and the path of the file to be created 
            //Fileinfo - class
            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13146\Desktop\.net\C_Sharp Files Concept\T17_Files3.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fileStream);
            try
            {
                writer.WriteLine("Web Development is used to develop web pages using various technologies");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
                fileStream.Close();
            }

        }
        /// <summary>
        /// Read the contents of the file using StreamReader class
        /// </summary>

        public void read()
        {

            //Specify the filename and the path of the file to be created 
            //Fileinfo - class
            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13146\Desktop\.net\C_Sharp Files Concept\T17_Files3.txt");
           
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(fileStream);
            try
            {
                string contents = reader.ReadToEnd();
                Console.WriteLine(contents);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                reader.Close();
                fileStream.Close();
            }

        }
        /// <summary>
        /// append method writes the content from the end (does not overwrite)
        /// </summary>
        public void append()
        {
            //Specify the filename and the path of the file to be created 
            //Fileinfo - class
            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13146\Desktop\.net\C_Sharp Files Concept\T17_Files3.txt");

            FileStream fileStream = fileInfo.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fileStream);
            try
            {
                writer.WriteLine("Web development technologies are Javascript, Angular, ReactJS, VueJs");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
                fileStream.Close();
            }

        }


    }
    internal class files1
    {
        public static void Main()
        {
            Files_Demo demo = new Files_Demo();
            demo.Write();
            demo.read();
            demo.append();
            demo.read();
        }
    }
}
