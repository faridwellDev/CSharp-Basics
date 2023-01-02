using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Example to Understand Dynamic Polymorphism in C#:

namespace Polymorphism2
{
    class Class1
    {
        //virtual function (overridable method)
        public virtual void Show()
        {
            //Parent class logic same for all child class
            Console.WriteLine("Parent class show method");
        }
    }

    class Class2 : Class1
    {
        //Override method
        public override void Show() {
            Console.WriteLine(
            "Child class show method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class2();
            obj1.Show(); //Resolve at Runtime

            Console.ReadLine();
        }
    }
}
