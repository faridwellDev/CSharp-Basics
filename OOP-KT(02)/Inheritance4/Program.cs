using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Rule 3: We can Initialize a Parent class variable by using the child class instance to make
//it a reference variable so that the reference will be consuming the memory of the child class instance.
//But in this case, also, we cannot call any pure child class members using the reference.

namespace Inheritance4
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
            A p; //p is a variable of class A
            B q = new B(); //q is an instance of class B

            //We can initialize a parent class variable using child class instance as follows

            p = q;
            p.Method1();
            p.Method2();

            //We cannot call any pure child class members using the reference p
            //p.Method3();
            Console.ReadLine();
        }
    }
}
