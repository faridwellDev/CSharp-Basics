using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    //public static class CommonTask
    //{
    //    public static bool IsEmpty (string value)
    //    {
    //        return true;
    //    }
    //    public static string GetComputerName()
    //    {
    //        return "Farid";
    //    }
    //}
    ////We can't inherit static class
    //public class NormalClass : CommonTask
    //{

    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            string machineName = System.Environment.MachineName;
            Console.WriteLine("The name of this machine is: " + machineName);
            Console.ReadLine();
            
        }
    }
}
