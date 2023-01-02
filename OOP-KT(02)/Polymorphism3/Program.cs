using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Inheritance-Based Method Overloading

namespace Polymorphism3
{
    class Class1
    {
        public void Add(int a, int b) {
            Console.WriteLine(a + b);
        }
        public void Add(float a, float b)
        {
            Console.WriteLine(a + b);
        }
    }
    class Class2 : Class1
    {
        public void Add(string s1, string s2)
        {
            Console.WriteLine(s1 + " " + s2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Class2 obj = new Class2();
            obj.Add(1, 2);
            obj.Add(20.5f, 30.7f);
            obj.Add("Priyanka", "Rout");
            Console.ReadLine();
        }
    }
}
