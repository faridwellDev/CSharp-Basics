using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Constructor Method Overloading

namespace Polymorphism4
{
    class ConstructorOverloading
    {
        int x, y, z;
        public ConstructorOverloading(int x)
        {
            Console.WriteLine("Constructor1 Called");
            this.x = 10;
        }
        public ConstructorOverloading(int x, int y)
        {
            Console.WriteLine("Constructor2 Called");
            this.y = y;
            this.x = x;
        }
        public ConstructorOverloading(int x, int y, int z) {
            Console.WriteLine("Constructor3 Called");
            this.z = z;
            this.x = x;
            this.y = y;
        }
        public void Display()
        {
            Console.WriteLine($"X={x}, Y={y}, Z={z}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstructorOverloading obj1 = new ConstructorOverloading(1);
            obj1.Display();
            ConstructorOverloading obj2 = new ConstructorOverloading(2, 5);
            obj2.Display();
            ConstructorOverloading obj3 = new ConstructorOverloading(3, 6, 10);
            obj3.Display();
            Console.ReadLine();
        }
    }
}
