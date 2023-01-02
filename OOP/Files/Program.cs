using System.IO;

namespace Files
{
    internal class Program
    {
        //File - Class
        //System.IO - namespace
        //SomeFileMethod() - methods
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello, World!");

            //string writeText = "Hello World!"; //Create a text string
            //File.WriteAllText("filename.txt", writeText); //Create a file and write the content of writeText to it

            //string readText = File.ReadAllText("filename.txt"); //Read the contents of the file
            //Console.WriteLine(readText); //Output the content

            string path = @"C:\C#\MyTest.txt";
            if(!File.Exists(path))
            {
                //Create a file to write to.
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

            // Open the file to read from.

            using (StreamReader sr = File.OpenText(path))
            {
                string line;
                while((line = sr.ReadLine()) != null) {
                    Console.WriteLine(line);
                }
            }

            string path1 = @"C:\C#\MyTest1.txt";
            if(!File.Exists(path1))
            {
                using (StreamWriter sw1 = File.CreateText(path1))
                {
                    sw1.WriteLine("Hello");
                    sw1.WriteLine("New");
                    sw1.WriteLine("World!");
                }
            }
        }
    }
}