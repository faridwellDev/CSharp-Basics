using System.IO;
using System.Text;

namespace File_InOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Directory currDir = new DirectoryInfo(".");

            //Basics
            //DirectoryInfo dereksDir = new DirectoryInfo(@"C:\Users\C#");
            //Console.WriteLine(dereksDir.FullName);
            //Console.WriteLine(dereksDir.Name);
            //Console.WriteLine(dereksDir.Parent);
            //Console.WriteLine(dereksDir.Attributes);
            //Console.WriteLine(dereksDir.CreationTime);

            //string[] customers =
            //{
            //    "Bob Smith",
            //    "Sally Smith",
            //    "Robert Smith"
            //};

            //string textFilePath = @"C:\C#\File_InOutput\testfile1.txt"; //Creating files
            //File.WriteAllLines(textFilePath, customers); //Writing on files

            //foreach(string cust in File.ReadAllLines(textFilePath))
            //{
            //    Console.WriteLine($"Customer: {cust}"); //Read files
            //}

            //DirectoryInfo myDataDir = new DirectoryInfo(@"C:\C#\File_InOutput");

            //FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

            //Console.WriteLine("Matches : {0}", txtFiles.Length);
            //foreach( FileInfo file in txtFiles) {
            //    Console.WriteLine(file.Name);
            //    Console.WriteLine(file.Length);
            //}


            //FileStream

            string textFilePath = @"C:\C#\File_InOutput\testfile2.txt"; //Create a file

            FileStream fs = File.Open(textFilePath,FileMode.Create);

            string randString = "This is a random string";

            byte[] rsByteArray = Encoding.Default.GetBytes(randString);
            fs.Write(rsByteArray, 0, rsByteArray.Length);
            fs.Position = 0;

            byte[] fileByteArra = new byte[rsByteArray.Length];

            for(int i = 0; i<rsByteArray
   .Length; i++)
            {
                fileByteArra[i] = (byte)fs.ReadByte();
            }
            Console.WriteLine(Encoding.Default.GetString(fileByteArra));

            fs.Close(); 
            Console.WriteLine("Hello, World!");
        }
    }
}