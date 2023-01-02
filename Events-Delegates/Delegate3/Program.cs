using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate3
{

    //Multicast Delegate Example in C#:

    public delegate void ProgramDelegate(double Widht, double Height);
    internal class Program
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine($"Area is {Width * Height}");
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine($"Perimeter is {2 * (Width + Height)}");
        }
        static void Main(string[] args)
        {
            //In regular procedure we need two method
            Program rect = new Program();
            //rect.GetArea(23.45, 67.89);
            //rect.GetPerimeter(23.45, 67.89);

            //To solving this issue we can use delegate

            ProgramDelegate rectDelegate = new ProgramDelegate(rect.GetArea);
            // RectangleDelegate rectDelegate = rect.GetArea;
            // binding a method with delegate object
            // In this example rectDelegate is a multicast delegate. 
            // You use += operator to chain delegates together.

            rectDelegate += rect.GetPerimeter;

            Delegate[] InvocationList = rectDelegate.GetInvocationList();
            Console.WriteLine("InvocationList: ");
            foreach (var item in InvocationList)
            {
                Console.WriteLine($" {item}");
            }
            Console.WriteLine();
            Console.WriteLine("Invoking Mulicast Delegate:");
            rectDelegate(23.45, 67.89);
            rectDelegate.Invoke(13.45, 76.89);

            Console.WriteLine();
            Console.WriteLine("Invoking Multicast Delegate After Removing one Pipeline:");
            //Removing a method from delegate object
            rectDelegate -= rect.GetPerimeter;
            rectDelegate.Invoke(13.45, 76.89);

            Console.ReadLine();
        }
    }
}
