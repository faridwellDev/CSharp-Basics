using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

//multi-level Inheritance in C#
//Multi - level inheritance occurs when a class is derived from another derived class.
//It is simply a situation where a derived class is created and used as a base class for another class.
namespace Inheritance7
{
    class ParentClass
    {
        public string name;
        public int Id = 9;

        //...
    }

    class ChildClass : ParentClass
    {
        //...
        //The Child class is the derived class in this case
    }

    class ThirdClass : ChildClass
    {
        //...
        //The ChildClass is the base class for the ThirdClass
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
