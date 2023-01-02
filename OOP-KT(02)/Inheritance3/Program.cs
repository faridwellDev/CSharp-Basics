using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Rule 2: In inheritance, the child class can access the parent class members
//but the parent classes can never access any members that are purely defined in the child class.

namespace Inheritance3
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
        public B()
        {
            Console.WriteLine("Class B Constructor is Called");
        }
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main()
        {
            A obj = new A();
            obj.Method1();
            obj.Method2();
            //The following line of code gives you compile time error
            //obj.Method3();
            Console.ReadLine();
        }
    }
}
