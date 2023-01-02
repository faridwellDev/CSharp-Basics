using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorDemo
{
    class DestructorDemo
    {
        public DestructorDemo()
        {
            Console.WriteLine("Constructor Object Created");
        }
        ~DestructorDemo()
        {
            string type = GetType().Name;
            Console.WriteLine($"Object {type} is Destroyed");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //DestructorDemo obj1 = new DestructorDemo();
            //DestructorDemo obj2 = new DestructorDemo();

            ////Making obj1 and obj2 ready for Garbage Collection
            //obj1 = null;
            //obj2 = null;
            //GC.Collect();
            //Console.ReadKey();

            //Destructor destroy once in a whole execution time

            Console.WriteLine("Main Method Execution Started");
            DestructorDemo obj1 = new DestructorDemo();

            //Making obj1 ready for Garbage Collection
            obj1 = null;
            GC.Collect();
            Console.WriteLine("Some Statement Executed Inside Main Method");
            obj1 = null;
            GC.Collect();
            Console.WriteLine("Some More Statement Executed Inside Main Method");
            GC.Collect();
            Console.WriteLine("Main Method Execution End");
            Console.ReadKey();
        }
    }
}
