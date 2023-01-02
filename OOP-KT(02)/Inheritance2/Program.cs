using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Rule 1: In C#, the parent classes constructor must be accessible to the child class,
//otherwise, the inheritance would not be possible because when we create the child
//class object first it goes and calls the parent class constructor so that the parent
//class variable will be initialized and we can consume them under the child class.

namespace Inheritance2
{
    class A
    {
        public A() {
            Console.WriteLine("Class A Constructor is Called");
        }
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }

    class B : A
    {
        B()
        {
            Console.WriteLine("Class B Constructor is Called");
        }
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main()
        {
            B obj = new B();
            obj.Method1();
            obj.Method2();
            obj.Method3();
            Console.ReadLine();
        }
    }
}
