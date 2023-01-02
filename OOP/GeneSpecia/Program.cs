using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Generalization & Specialization

//Specialization :  Something is already existing and then we are deriving something from that existing one by adding some extra features.
//Generalizaton :  There are no dimensions for shape. It’s a generalized term. So, this is an example of Generalization in C#.
// Shape : There is no dimension for shape. It's a generalized term. So, this is an example of Generalization in C#.

namespace GeneSpecia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Specialization

            //Cuboid cuboid = new Cuboid(3, 5, 7);
            //Console.WriteLine($"Volume is : {cuboid.Volume()}");
            //Console.WriteLine($"Area is : {cuboid.Area()}");
            //Console.WriteLine($"Perimeter is : {cuboid.Perimeter()}");

            Innova innova = new Innova();
            innova.Start();
            innova.Stop();

            BMW bmw = new BMW();
            bmw.Start();
            bmw.Stop();

            Console.ReadLine();
        }
    }

    //Generalization
    interface ICar
    {
        void Start();
        void Stop();
    }

    public class Innova : ICar
    {
        public void Start()
        {
            Console.WriteLine($"Innova Start");
        }
        public void Stop()
        {
            Console.WriteLine($"Innova Stop");
        }
    }

    public class BMW : ICar
    {
        public void Start() { Console.WriteLine("BMW Start"); }
        public void Stop() { Console.WriteLine($"BMW Stop"); }
    }

    //Specialization

    //class Rectangle
    //{
    //    public int Length;
    //    public int Breadth;
    //    public int Area()
    //    {
    //        return Length * Breadth;
    //    }
    //    public int Perimeter()
    //    {
    //        return 2 * (Length + Breadth);
    //    }
    //}
    //class Cuboid : Rectangle
    //{
    //    public int Height;
    //    public Cuboid(int l, int b, int h)
    //    {
    //        Length = l;
    //        Breadth = b;
    //        Height = h;
    //    }
    //    public int Volume()
    //    {
    //        return Length * Breadth * Height;
    //    }
    //}
}
