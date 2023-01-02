using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inheritance
{

    //Single Inheritance
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Creating object of Child Class and 
    //        //Invoke the methods of Parent and Child Classes

    //        Cuboid obj = new Cuboid(2, 4, 7);
    //        Console.WriteLine($"Volume is : {obj.Volume()}");
    //        Console.WriteLine($"Area is : {obj.Area()}");
    //        Console.WriteLine($"Perimeter is : {obj.Perimeter()}");
    //        Console.ReadLine();
    //    }
    //}

    //2-> How to implement inheritance
    //Parent Class
    //public class Rectangle
    //{
    //    public int length;
    //    public int breadth;
    //    public int Area()
    //    {
    //        return length * breadth;
    //    }
    //    public int Perimeter()
    //    {
    //        return 2 * (length + breadth);
    //    }
    //}

    ////Child class
    //class Cuboid : Rectangle
    //{
    //    public int height;
    //    public Cuboid(int l, int b, int h)
    //    {
    //        length= l;
    //        height= h;
    //        breadth= b;
    //    }
    //    public int Volume()
    //    {
    //        return length * breadth * height;
    //    }
    //}


    class A
    {
        //Rule1
        //public A()
        //{
        //    Console.WriteLine($"Class A Constructor is Called");
        //}

        //public void Method1()
        //{
        //    Console.WriteLine("Method 1");
        //}

        //public void Method2()
        //{
        //    Console.WriteLine("Method 2");
        //}
        //..............................................................................................
        //Rule2

        //public A()
        //{
        //    Console.WriteLine("Class A Constructor is Called");
        //}
        //public void Method1()
        //{
        //    Console.WriteLine("Method 1");
        //}
        //public void Method2()
        //{
        //    Console.WriteLine("Method 2");
        //}
        //..............................................................................................

        //Rule 3
        //public A()
        //{
        //    Console.WriteLine("Class A Constructor is Called");
        //}
        //public void Method1()
        //{
        //    Console.WriteLine("Method 1");
        //}
        //public void Method2()
        //{
        //    Console.WriteLine("Method 2");
        //}

        //Rule 4
        //public A()
        //{
        //    Console.WriteLine("Class A Constructor is Called");
        //}
        //public void Method1()
        //{
        //    Console.WriteLine("Method 1");
        //}
        //public void Method2()
        //{
        //    Console.WriteLine("Method 2");
        //}

        //Rule 6
        //public A(int number)
        //{
        //    Console.WriteLine($"Class A Constructor is Called : {number}");
        //}
        //public void Method1()
        //{
        //    Console.WriteLine("Method 1");
        //}
        //public void Method2()
        //{
        //    Console.WriteLine("Method 2");
        //}

        //How to pass dynamic value to parent class constructor in C#

        //public A(int number)
        //{
        //    Console.WriteLine($"Class A Constructor is Called : {number}");
        //}
        //public void Method1()
        //{
        //    Console.WriteLine("Method 1");
        //}
        //public void Method2()
        //{
        //    Console.WriteLine("Method 2");
        //}
    }

    internal class Program : A
    {
        //Rule1

        //public Program()
        //{
        //    Console.WriteLine("Class Program Constructor is Called");
        //}
        //public void Method3()
        //{
        //    Console.WriteLine("Method 3");
        //}
        //..............................................................................................

        //Rule 2
        //public Program()
        //{
        //    Console.WriteLine("Class Program Constructor is Called");
        //}
        //public void Method3()
        //{
        //    Console.WriteLine("Method 3");
        //}

        //..............................................................................................

        //Rule 3

        //public Program()
        //{
        //    Console.WriteLine("Class B Constructor is Called");
        //}
        //public void Method3()
        //{
        //    Console.WriteLine("Method 3");
        //}
        //..............................................................................................

        //Rule 4
        //public Program()
        //{
        //    Console.WriteLine("Class B Constructor is Called");
        //}
        //public void Method3()
        //{
        //    Console.WriteLine("Method 3");
        //}
        //..............................................................................................

        //Rule 6:
        //public Program() //Eror for no argument
        //{
        //    Console.WriteLine("Class B Constructor is Called");
        //}
        //public void Method3()
        //{
        //    Console.WriteLine("Method 3");
        //}

        //..............................................................................................


        //Pass dynamic value to parent class constructor
        //public Program(int num) : base(num)
        //{
        //    Console.WriteLine("Class B Constructor is Called");
        //}
        //public void Method3()
        //{
        //    Console.WriteLine("Method 3");
        //}
        static void Main(string[] args)
        {
            //Rule1:
            //Program obj = new Program();
            //obj.Method1();
            //obj.Method2();
            //obj.Method3();
            //Console.ReadLine();
            //....................................................................................................
            //Rule2: Parent class can never access  childs pure method
            //A obj = new A();
            //obj.Method1();
            //obj.Method2();
            ////obj.Method3(); //The following line of code gives you compile time error
            /////obj.Method3(); //Never possible
            //Console.ReadKey();
            //....................................................................................................




            //Rule3: We cannot call any pure child class members using the reference p

            //    A p; //p is a variable of class A
            //    Program q = new Program();

            //    ////We can initialize a parent class variable using child class instance as follows
            //    p = q; //now, p is a referance of parent class crated created by using child class instance
            //    now you can call members of A class as follows
            //    p.Method1();
            //p.Method2();
            //    Console.ReadLine();

            //        //we cannot call any pure child class members using the referance p
            //        //p.Method3()

            //        //Program obj = new Program();
            //        //obj.Method1();
            //        //obj.Method2();
            //        //obj.Method3();
            //....................................................................................................


            //        //Rule4

            //Object obj1 = new Object();
            //Console.WriteLine($"obj1 type: {obj1.GetType()}");
            //A obj2 = new A();
            //Console.WriteLine($"obj2 type: {obj2.GetType()}");
            //Program obj3 = new Program();
            //Console.WriteLine($"obj3 type: {obj3.GetType()}");
            //Console.ReadLine();

            //        //    Constructor Execution in the above Example:
            //        //    When we create an instance of the Object class, only the Object class constructor is called.
            //        //    But when we create an instance of Class A, two constructors are called.First, it will execute 
            //        //    the Object class constructor and then it will execute the Class A constructor.
            //        //    When we create an instance of Class B, then three constructors are executed.First, 
            //        //    it will execute the Object class constructor, then it will execute the class A constructor, and last it will execute the class B Constructor.

            //        //Rule6:
            //Program obj = new Program();
            //Console.ReadLine();

            ////Pass dynamic value to Constructor

            //Program obj1 = new Program(10);
            //Program obj2 = new Program(20);
            //Program obj3 = new Program(30);
            //Console.ReadLine();

            //5 types of inheritance (1-3 : Single Inheritance, 4-5: Multiple Inheritance)
            //1. Single Inheritance
            //2. Multilevel
            //3. Hierarchical (When more than one derived class is created from a single base class then it is called Hierarchical inheritance.)
            //4. Hybrid
            //5. Mulple (Derived class is created from more than one base class) (single + hierarchical + multilevel)
        }
    }
}

//Advantages of Inheritance in C#:
//Code reusability: We can reuse the members of the parent class or base class in the child class
//or derived class. So, there is no need to re-define the members again in the child class. So, less code is required in the class.

//In the next article, I am going to discuss Types of Inheritance in C# with Examples. Here,
//in this article, I try to explain Inheritance in C# with Examples and I hope you enjoy this article.
//I would like to have your feedback. Please post your feedback, question, or comments about this article.

//How to Make use of Inheritance in Realtime Application Development?
//Generally, when we develop an application, we will be following a process as follows.

//Identify the entity associated with the application
//Identify the attribute that is associated with the application.
//Now separate the attribute of each entity in a hierarchical order without having any duplicates.
//Convert those entities into classes.

//Is-A, HaS-A relationship

//class Rectangle
//{
//    Some Data Members
//    Some Member Functions
//}
//class Cuboid : Rectangle
//{
//    Some Data Members
//    Some Member Functions
//}
//class Table
//{
//    Rectangle top;
//    int legs;
//}


//The class Cuboid is inherited from the Rectangle class. So, can we say that a Cuboid IA A Rectangle?
//Yes. So, the relationship between the Rectangle class and Cuboid class is the Is A relationship.
//So, the point that you need to remember is whenever we are making the Inheritance relationship 
//or Parent-Child relationship, then we can say that relationship as IS-A relationship in object-oriented programming languages.

//Next, our Table class, it is having a top variable that is of the type Rectangular.
//That means the Table class is having an object of the Rectangle class.
//So, can we say that the Table class HAS A Rectangle? Yes, the Table
//class Has a Rectangle.So, the relationship between the Table class and the Rectangle class is the Has A relationship.