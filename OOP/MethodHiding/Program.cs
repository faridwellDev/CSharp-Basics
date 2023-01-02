using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Class show Method");
        }
        public void Display()
        {
            Console.WriteLine("Parent Class Display Method");
        }
    }

    public class Child : Parent
    {
        //Method Overriding
        public override void Show()
        {
            Console.WriteLine("Child Class Show Method");
        }

        //Method Hiding/ Shadowing
        public new void Display()
        {
            Console.WriteLine("Child Class Display Method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Child obj = new Child();
            Parent obj = new Child(); //For understading diff of Hiding and Overriding
            obj.Show();
            obj.Display();
            Console.ReadLine();
        }
        //Output: Child Class Show Method
        // Child Class Display Method
    }

}
