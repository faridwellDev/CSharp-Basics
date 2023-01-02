using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System;

namespace Classes
{
    internal class Program
    {
        //3-> How can we create a class and object in C#
        public class Calculator
        {
            public int CalculateSum(int no1, int no2) //Class definition template/blueprint
            {
                return no1 + no2;
            }
        }

        //Calculator calObject = new Calculator(); //Creating object and accessing class members
        //calObject.CalculateSum(10,20);
        //........................................................................................................................

        //4-> Difference beteween Class and Objects
        //Class -> Employee ->Properties,Fields,Methods 
        //Emp1 -> Properties,Fields,Methods, Emp2->Same as before (objects)
        //........................................................................................................................

        //Constructor :

        //2-> Example to Understand Constructor in C#

        //Before Compilation
        //class Test
        //{
        //    int i;
        //}
        ////After Compilation
        //class Test
        //{
        //    int i;
        //    public Test()
        //    {
        //        i = 0;
        //    }
        //}
        //........................................................................................................................

        //3-> Implicitly constructor
        //class Test
        //{
        //    public int i;
        //    public bool b;
        //    public string s;
        //}
        //........................................................................................................................

        //4-> Explicit Constructor
        //class ExplicitConstructor
        //{
        //    public ExplicitConstructor()
        //    {
        //        Console.WriteLine("Explicit Constructor is Called!");
        //    }
        //}
        //........................................................................................................................

        //12-> Static Constructor
        //int i;
        //static int j;
        //static Program()
        //{
        //    Console.WriteLine(0 + 6);
        //    j = 100; //Allowed
        //    i = 101; //Not allowed
        //}

        //........................................................................................................................

        //private Program()
        //{
        //    Console.WriteLine("Private Parameterless Constructor is Called");
        //}
        //private Program(string message)
        //{
        //    Console.WriteLine("Private Parameterized Constructor is Called");
        //}
        //........................................................................................................................

        //2-> System Defined Constructor
        //class Employee
        //{
        //    public int Id, Age;
        //    public string Address, Name;
        //    public bool IsPermanent;
        //}
        //........................................................................................................................

        //5-> User Defined Constructor
        class Employee
        {
            public int Id, Age;
            public string Address, Name;
            public bool IsPermanent;
            //User Defined Default Constructor
            public Employee()
            {
                Id = 100;
                Age = 30;
                Address = "Bhubaneswar";
                Name = "Anurag";
                IsPermanent = true;
            }
            public void Display()
            {
                Console.WriteLine("Employee Id is:  " + Id);
                Console.WriteLine("Employee Age is:  " + Age);
                Console.WriteLine("Employee Address is:  " + Address);
                Console.WriteLine("Employee Name is:  " + Name);
                Console.WriteLine("Is Employee Permanent:  " + IsPermanent);
            }
        }
        //........................................................................................................................

        //7-> Paremeterized Constructor
        //public class ParameterizedConstructor
        //{
        //    int x;
        //    public ParameterizedConstructor(int i)
        //    {
        //        Console.WriteLine($"Parameterized Constructor is Called : {i}");
        //    }
        //    public void Display()
        //    {
        //        Console.WriteLine($"Value of X = {x}");
        //    }
        //}
        //........................................................................................................................

        //9-> Copy Constructor
        //public class CopyConstructor
        //{
        //    int x;
        //    public CopyConstructor(int i)
        //    {
        //        x = i;
        //    }
        //    public CopyConstructor (CopyConstructor obj)
        //    {
        //        this.x = obj.x;
        //    }
        //    public void Display()
        //    {
        //        Console.WriteLine($"Value of X = {x}");
        //    }
        //}
        //........................................................................................................................

        //13-> Private constructor

        //private Program()
        //{
        //    Console.WriteLine("This is private constructor");
        //}

        //4-> Destructor

        //class DestructorDemo
        //{
        //    public DestructorDemo()
        //    {
        //        Console.WriteLine("Constructor Object Created");

        //    }
        //    ~DestructorDemo()
        //    {
        //        string type = GetType().Name;
        //        Console.WriteLine($"Object {type} is Destroyed");
        //    }
        //}

        //........................................................................................................................
        static void Main(string[] args)
        {
            #region Comments
            //Console.WriteLine("Hello, World!");
            //Car myObj1 = new Car("Mustang");
            //Console.WriteLine(myObj1.color);
            ////Create two objects of Car:
            //Car myObj2 = new Car("Ferrari");
            //Console.WriteLine(myObj2.color);
            //Console.WriteLine(myObj2.maxSpeed);
            //myObj2.fullThrottle();
            //Console.WriteLine(myObj1.model);

            //Properties

            //Car myObj = new Car();
            //myObj.Name = "Test";
            //Console.WriteLine(myObj.Name);

            //Car myCar = new Car();

            //myCar.honk();

            //Console.WriteLine(myCar.brand + " " + myCar.modelName);

            //Polymorphism myAnimal = new Polymorphism(); //Create an polymorphism class
            //Polymorphism myPig = new Pig();
            //Polymorphism myDog = new Dog();

            //myAnimal.animalSound();
            //myPig.animalSound();
            //myDog.animalSound();

            //Abstraction

            //Cow myCow = new Cow();
            //myCow.animlaSound(); //call the abstract method
            //myCow.sleep();

            //Doll myDoll  = new Doll();
            //myDoll.animalSound();

            //DemoClass myObj = new DemoClass();
            //myObj.myMethod();
            //myObj.myOtherMethod();

            // Enum
            //Enums myVar = Enums.High;
            //Console.WriteLine(myVar);

            //int myNum = (int)Months.April;
            //Console.WriteLine(myNum);
            //int myNum2 = (int)Months.July;
            //Console.WriteLine(myNum2);


            //Use enums when you have values that you know aren't going to change, like month days, days, colors, deck of cards, etc.
            //Months myVar = Months.May;
            //switch(myVar)
            //{
            //    case Months.May:
            //        Console.WriteLine("May");
            //        break;
            //    case Months.February: Console.WriteLine("February");
            //        break;
            //}

            ////Class
            //Calculator calObject= new Calculator();

            //int result = calObject.CalculateSum(10, 20);
            //Console.WriteLine(result);
            //Console.ReadLine();


            //3-> Implicit Constructor
            //Test obj = new Test();
            //Console.WriteLine($"i = {obj.i}");
            //Console.WriteLine($"b = {obj.b}");

            ////Value null will be printed, so here we checking the null
            //if(obj.s == null)
            //{
            //    Console.WriteLine("s = null");
            //}
            //Console.ReadLine();

            //........................................................................................................................

            //4->Explicit Constructor

            //ExplicitConstructor obj1 = new ExplicitConstructor(); //Calling is explicit where Defining is both
            //                                                      // Whenever we are creating the instance, we are calling the constructor. 
            //ExplicitConstructor obj2 = new ExplicitConstructor();
            //ExplicitConstructor obj3 = new ExplicitConstructor();
            //ExplicitConstructor obj4 = new ExplicitConstructor();
            Console.ReadLine();
            //........................................................................................................................

            //2-> Implicit or Default Constructor 

            //Employee e1 = new Employee();
            //Console.WriteLine("Employee Id is: " + e1.Id);
            //Console.WriteLine("Employee Name is: " + e1.Name);
            //Console.WriteLine("Employee Age is: " + e1.Age);
            //Console.WriteLine("Employee Address is: " + e1.Address);
            //Console.WriteLine("Is Employee Permanent: " + e1.IsPermanent);
            //Console.ReadLine();
            //........................................................................................................................

            //5-> User-defined Constructor

            Employee e1 = new Employee();
            e1.Display();
            Console.ReadLine();
            //........................................................................................................................

            //7-> Paremeterized Constructor

            //ParameterizedConstructor obj1 = new ParameterizedConstructor(10);
            //obj1.Display();
            //ParameterizedConstructor obj2 = new ParameterizedConstructor(20);
            //obj2.Display();
            //Console.ReadLine();
            //........................................................................................................................

            //9-> Copy Constructor

            //CopyConstructor obj1 = new CopyConstructor(10);

            //obj1.Display();
            //CopyConstructor obj2 = new CopyConstructor(obj1);
            //obj2.Display();
            //Console.ReadLine();
            //........................................................................................................................

            //10 -> Static Constructor

            //Console.WriteLine("Main Method Execution Started....");
            //Console.ReadLine();

            //If a constructor is declared explicitly by using the static modifier, then it is called a static constructor in C#.
            //........................................................................................................................

            //13-> Priavate Constructor

            //Program p = new Program();
            //Console.WriteLine("Main method");
            //Console.ReadKey();

            //........................................................................................................................

            #endregion

            /*Baby obj = new Baby();*/ //this is possible if private + parent both constructor present in the class

            //but if there is present just private access modifier and we cant then but if it presents in same parent class then it can like

            //Parent.Child obj = new Parent.Child();
            //Console.ReadLine();
            //Program obj1 = new Program();
            //Program obj2 = new Program("Hello");
            //Console.ReadKey();
            //........................................................................................................................

            //4-> Destructor

            //DestructorDemo obj1 = new DestructorDemo();
            //DestructorDemo obj2 = new DestructorDemo();

            ////Making obj1 for Garbage Collection
            //obj1 = null;

            //obj2 = null;
            //GC.Collect(); //for garbage collection
            //Console.ReadLine();
        }
    }




    //Implicit constructor

    //class Test
    //{
    //    public int i;
    //    public bool b;
    //    public string s;
    //}

    //Explicit constructor

    //class ExplicitConstructor
    //{
    //    public ExplicitConstructor()
    //    {
    //        Console.WriteLine("Explicit Constructor is Called!");
    //    }
    //}

    //Types of instructor
    //1. Dafault or parameterless , 2. Parameterized, 3. Copy , 4. Static, 5. Private


    //Implicit or Default

    //class Employee
    //{
    //    public int Id, Age;
    //    public string Address, Name;
    //    public bool IsPermanent;
    //}

    //User-defined Default Constructor
    //class Employee
    //{
    //    public int Id, Age;
    //    public string Address, Name;
    //    public bool IsPermanent;

    //    //User Defined Default constructor

    //    public Employee()
    //    {
    //        Id = 1604045;
    //        Age = 25;
    //        Address = "Block-D, Road-3, Mirpur-1";
    //        Name = "Faridul Islam";
    //        IsPermanent = false;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine("Employee Id is: " + Id);
    //        Console.WriteLine("Employee Age is: " + Age);
    //        Console.WriteLine("Employee Address is: " + Address);
    //        Console.WriteLine("Employee Name is: " + Name);
    //        Console.WriteLine("Is Employee Permanent: " + IsPermanent);
    //    }
    //}

    //Parametarized Constructor

    //public class ParameterizedConstructor
    //{
    //    int x;
    //    public ParameterizedConstructor(int i)
    //    {
    //        x = i;
    //        Console.WriteLine($"Parameterized Constructor is Called: {i}");
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine($"Value of X = {x}");
    //    }
    //}

    //Copy Constructor in C#
    //If we want to create multiple instances with the same values then
    //we need to use the copy constructor in C#, in a copy constructor the
    //constructor takes the same class as a parameter to it.


    //public class Copyconstructor
    //{
    //    int x;

    //    //Parameterized constructor
    //    static Copyconstructor()
    //    {
    //        Console.WriteLine("0 + 5");
    //    }

    //    public Copyconstructor(int x)
    //    {
    //        this.x = x;
    //    }
    //    public Copyconstructor(Copyconstructor obj)
    //    {
    //        this.x = obj.x;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine($"Value of X = {x}");
    //    }
    //}


    //Why we need constructor in c#


    //Static constructor Demo

    //The static Constructor in C# will be invoked only once. There is no matter how many
    //instances (objects) of the class are created, it is going to be invoked only once
    //and that is when the class is loaded for the first time.

    //class Example
    //{
    //    int i;
    //    static int j;

    //    public Example()
    //    {
    //        Console.WriteLine("Default Constructor Executed");
    //        i = 100;
    //    }

    //    static Example()
    //    {
    //        Console.WriteLine("Static Constructor Executed");
    //    }

    //    public void Increment()
    //    {
    //        i++;
    //        j++;
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine("Value of i : " + i);
    //        Console.WriteLine("Value of j : " + j);
    //    }
    //}

    //Private Constructor Restricting Inheritance in C#

    //public class Parent
    //{
    //    //Private constructor

    //    private Parent() {
    //        Console.WriteLine("Parent class private constructor in Called.");

    //    }

    //    //public constructor
    //    public Parent (string Message)
    //    {
    //        Console.WriteLine("Parent class public constructor is called.");
    //    }
    //}

    //public class Child : Parent
    //{
    //    public Child() : base("Hello")
    //    {
    //        Console.WriteLine("Child Class Public Constructor is Callled");
    //    }
    //}
    //public class Baby : Child
    //{
    //    public void Speed()
    //    {
    //        Console.WriteLine("Hi i am here");
    //    }
    //}

    //If child class present in parent class then we can inherit 

    //public class Parent
    //{
    //    //private constructor
    //    private Parent() {
    //        Console.WriteLine("Parent Class Constructor is Called");
    //    }
    //    public class Child : Parent
    //    {
    //        public Child()
    //        {
    //            Console.WriteLine("Child Class Public Constructor is Called");
    //        }
    //    }
    //}

    //
    //public class Child : Parent
    //{
    //    public Child() : base("Hello")
    //    {
    //        Console.WriteLine("Child Class Public Constructor is Callled");
    //    }
    //}

    //If you want to restrict inheritance then don’t go for the private constructor,
    //instead, make the Class Sealed which will restrict the class to be inherited
    //from either outside or inside. 

    //public sealed class Parent
    //{
    //    //Private Constructor
    //    private Parent() {
    //        Console.WriteLine("Parent Class Private Constructor is Called");
    //    }
    //    public class Child1 : Parent
    //    {
    //        public Child1()
    //        {
    //            Console.WriteLine("Child1 Class Public Constructor is Called");
    //        }
    //    }
    //}
    //public class Child2 : Parent
    //{
    //    public Child2()
    //    {
    //        Console.WriteLine("Child2 Class Public Constructor is Called");
    //    }
    //}


}