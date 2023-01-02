using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Rule 4: In Rule1 we learned whenever the child class instance is created,
//the child class constructor will implicitly call its parent classes constructor
//but if the parent classes constructor is parameterless. If the constructor of the
//Parent class is parameterized, then the Child class constructor cannot implicitly call its Parent’s constructor.

namespace Inheritance5
{
    class A
    {
        public A(int number)
        {
            Console.WriteLine($"Class A Constructor is Called : {number}");
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
        public B() : base(10)
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
            Console.ReadLine();
        }
    }
}
