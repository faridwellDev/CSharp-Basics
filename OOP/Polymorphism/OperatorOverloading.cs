using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class OperatorOverloading
    {
        private int real;
        private int img;
        public OperatorOverloading(int r = 0, int i = 0)
        {
            real = r;
            img = i;
        }
        //public static OperatorOverloading Add (OperatorOverloading c1, OperatorOverloading c2)
        //{
        //    OperatorOverloading temp = new OperatorOverloading();
        //    temp.real = c1.real + c2.real;
        //    temp.img= c1.img + c2.img;
        //    return temp;
        //}

        //Now using operator
        public static OperatorOverloading operator + (OperatorOverloading c1, OperatorOverloading c2)
        {
            OperatorOverloading temp = new OperatorOverloading();
            temp.real = c1.real + c2.real;
            temp.img = c1.img + c2.img;
            return temp;
        }
        public void Display()
        {
            Console.WriteLine($"{real} +i{img}");
        }
    }
}
