using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example to Understand Multicast Delegates with Return Type in C#
namespace Delegate5
{
    // Delegate's return type is int
    public delegate int SampleDelegate();

    internal class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate del = new SampleDelegate(MethodOne);
            del += MethodTwo;

            // The Value Returned By Delegate will be 2, return by the MethodTwo(),
            // as it is the last method in the invocation list.

            int ValueReturnedByDelegate = del();
            Console.WriteLine($"Returned Value = {ValueReturnedByDelegate}");

            Console.ReadLine();
        }
        //This method return one
        public static int MethodOne()
        {
            Console.WriteLine("MethodOne is Executed");
            return 1;
        }
        
        // This method returns two
        public static int MethodTwo()
        {
            Console.WriteLine("MethodTwo is Executed");
            return 2;
        }
    }
}
