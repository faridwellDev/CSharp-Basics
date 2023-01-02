using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Example to understand Compile time polymorphism

namespace Polymorphism1
{
    internal class Program
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(long a, long b)
        { Console.WriteLine(a + b);
            Console.WriteLine("Long");
        }
        public void Add(float x, float y) { Console.WriteLine(x + y);
            Console.WriteLine("Float");
        }
        public void Add(double x, double y)
        {
            Console.WriteLine("Dobule");
            Console.WriteLine(x + y);
        }
        public void Add(decimal x, decimal y)
        {
            Console.WriteLine(x + y);
            Console.WriteLine("Decimal");
        }
        public void Add(string s1, string s2)
        {
            Console.WriteLine(s1 + " " + s2);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Add(1, 2);
            obj.Add(10.5, 20.5);
            obj.Add("Priyanka", "Route");
            Console.ReadLine();
        }
    }
}
