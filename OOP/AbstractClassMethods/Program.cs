using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassMethods
{
    //2-> Implement Abstract Classes and Abstract Methods in C# Application Development
    public abstract class Shape
    {
        public double Height;
        public double Width;
        public double Radius;
        public const float PI = 3.14f;
        public abstract double GetArea();
    }

    public class Rectangle : Shape
    {
        public Rectangle (double Height, double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double GetArea()
        {
            return PI * Radius * Radius;
        }
    }

    public class Triangle : Shape
    {
        public Triangle(double Height, double Width)
        {
            this.Height = Height;
            this.Width = Width;
        }
        public override double GetArea()
        {
            return (Width * Height) / 2;
        }
    }

    public class Cone : Shape
    {
        public Cone(double radius, double Height)
        {
            this.Radius = radius;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return PI * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
    }

    //public abstract class AbsParent
    //{
    //    public void Add(int x, int y)
    //    {
    //        Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
    //    }
    //    public void Sub(int x, int y) { 
    //    Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
    //    }

    //    public abstract void Mul(int x, int y);
    //    public abstract void Div(int x, int y);

    //}

    //11-> Static and non-static concrete members of the abstract class 

    //.........................................................................................................
    public class Program //: AbsParent
    {

        //Staic and non-static method
        //public override void AbstractMethod()
        //{
        //    Console.WriteLine("AbstractMethod Implemented in Child Class");
        //}
        //public override void getMethod()
        //{
        //    //
        //}
        //public override void Mul(int x, int y)
        //{
        //    Console.WriteLine($"Mulitiplication of {x} and {y} is : {x * y}");
        //}
        //public override void Div(int x, int y)
        //{
        //    Console.WriteLine($"Division of {x} and {y} is : {x / y}");
        //}
        ////For problem Note
        //public void Mod (int x, int y)
        //{ Console.WriteLine($"Modulos of {x} and {y} is : {x % y}");
        //}
        static void Main(string[] args)
        {
            ////how to implement the abstract methods
            //AbsParent absChild = new Program(); //we can't create AbsParent because of it is abstract class so we create AbsChild means Program
            //absChild.Add(1, 2);
            //absChild.Sub(1, 2);
            //absChild.Mul(1, 2);
            //absChild.Div(1, 2);
            //Console.ReadLine();

            //9-> Create a Reference for the Abstract Class
            //    Creating Child class Instance
            //Program absChild = new Program();

            ////Creating abstract class reference pointing to child class object
            //AbsParent absParent = absChild;

            //absParent.Add(10, 5);
            //absParent.Sub(10, 5);
            //absParent.Mul(10, 5);
            //absParent.Div(10, 5);
            //but we can't call Mod because of it is pure child class method
            //absParent.Mod(10, 5);

            //Static and non-static 

            //Calling Abstract Class Static Method using Class Name
            //AbsParent.StaticMethod();

            //Program absChild = new Program();
            ////Calling the Abstract Class Concrete Method using Child Class Object
            //absChild.NonStaticMethod();

            ////Calling the Abstract Method using Child Class Object
            //absChild.AbstractMethod();

            //...............................................................................................
            //Example to Implement Abstract Classes and Abstract Methods in C# Application Development:
            Rectangle rectangle = new Rectangle(10, 20);
            Console.WriteLine($"Area of Recatangle : {rectangle.GetArea()}");

            Triangle triangle = new Triangle(15, 25);
            Console.WriteLine($"Area of Triange: {triangle.GetArea()}");

            Circle circle = new Circle(12);
            Console.WriteLine($"Area of Circle: {circle.GetArea()}");

            Cone cone = new Cone(5, 15);
            Console.WriteLine($"Area of Cone: {cone.GetArea()}");

            Console.ReadLine();
        }
    }
}
