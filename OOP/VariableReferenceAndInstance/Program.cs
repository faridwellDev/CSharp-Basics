using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableReferenceAndInstance
{
    internal class Program
    {
        int x = 10;
        static void Main(string[] args)
        {
            //Console.WriteLine(x); //because x is not an object or static
            //so solution is creating object
            //Program e = new Program();
            //Console.WriteLine(e.x);
            //Console.ReadKey();

            Program e1 = new Program(); //e1 is Instance of class Example
            Program e2 = e1; //e2 is Reference of class Example
            Console.WriteLine($"e1.x: {e1.x} and e2.x: {e2.x}");
            e1.x = 50; //Modifying the x variable of e1 instance
            Console.WriteLine($"e1.x: {e1.x} and e2.x {e2.x}");
            Console.ReadKey();
        }
    }
}
