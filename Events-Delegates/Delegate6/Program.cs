using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate6
{
    // Delegate has an int output paremeter
    public delegate void SampleDelegate(out int Integer);
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate del = new SampleDelegate(MethodOne);
            del += MethodTwo;

            // The ValueFromoutPutParameter will be 2, initialized by MethodTwo(),
            // as it is the last method in the invocation list.

            int ValueFromoutPutParameter = -1;
            del (out ValueFromoutPutParameter);

            Console.WriteLine($"Returned Value = {ValueFromoutPutParameter}");
            Console.ReadLine();
        }

        // This method sets output parameter Number to 1
        public static void MethodOne(out int Number)
        {
            Console.WriteLine("MethodOne is Executed");
            Number = 1;
        }

        // This method sets output parameter Number to 2
        public static void MethodTwo(out int Number)
        {
            Console.WriteLine("MethodTwo is Executed");
            Number = 2;
        }
    }
}
