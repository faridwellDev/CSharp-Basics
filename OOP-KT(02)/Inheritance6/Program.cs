using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hierarchical Inheritance

namespace Inheritance6
{
    class ParentClass
    {
        public string name;
        public int Id = 9;

        public void displayParentClassDetails()
        {
            Console.WriteLine($"I am {name}");
            Console.WriteLine($"ID : {Id}");
        }
    }
    internal class ChildClass : ParentClass
    {
        public void getIdFromParentClass()
        {
            Console.WriteLine("Displaying from my Child Class");
            Console.WriteLine($"This is my ID : {Id}.");
        }
    }
    class AnotherChildClass : ParentClass
    {
        public void getIdFromParentClass()
        {
            Console.WriteLine("Displaying from my other Child Class");
            Console.WriteLine($"This is my ID : {Id}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //accessing the inherited members in the parent class (from the child class)
            ChildClass child = new ChildClass();
            child.getIdFromParentClass();

            //accessing the inherited members in the parent class (from the other child class)
            AnotherChildClass anotherChild = new AnotherChildClass();
            anotherChild.getIdFromParentClass();
            Console.ReadLine();
        }
    }
}
