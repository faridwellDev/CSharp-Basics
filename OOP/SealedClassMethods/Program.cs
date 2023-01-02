using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassMethods
{
    //Sealed Class
    //public class Employee
    //{
    //    protected int Eid, Eage;
    //    protected string Ename, Eaddress;
    //    public virtual void GetEmployeeData()
    //    {
    //        Console.WriteLine("Enter Emplpyee Details:");
    //        Console.Write("Enter Employee ID:");
    //        Eid = int.Parse(Console.ReadLine());
    //        Console.Write("Enter Employee Name:");
    //        Ename = Console.ReadLine();
    //        Console.Write("Enter Employee Address:");
    //        Eaddress = Console.ReadLine();
    //        Console.Write("Enter Employee Age:");
    //        Eage = int.Parse(Console.ReadLine());
    //    }
    //    public virtual void DisplayEmployeeData()
    //    {
    //        Console.WriteLine("\nEmplpyee Details Are:");
    //        Console.WriteLine($"Employee ID: {Eid}");
    //        Console.WriteLine($"Employee Name: {Ename}");
    //        Console.WriteLine($"Employee Address: {Eaddress}");
    //        Console.WriteLine($"Employee Age: {Eage}");
    //    }
    //}
    //public sealed class Manager : Employee
    //{
    //    double Bonus, Salary;
    //    public override void GetEmployeeData()
    //    {
    //        Console.WriteLine("Enter Manager Details:");
    //        Console.Write("Enter Manager ID:");
    //        Eid = int.Parse(Console.ReadLine());
    //        Console.Write("Enter Manager Name:");
    //        Ename = Console.ReadLine();
    //        Console.Write("Enter Manager Salary:");
    //        Salary = Convert.ToDouble(Console.ReadLine());
    //        Console.Write("Enter Manager Bonus:");
    //        Bonus = double.Parse(Console.ReadLine());
    //    }
    //    public override void DisplayEmployeeData()
    //    {
    //        Console.WriteLine("\nManager Details Are:");
    //        Console.WriteLine($"Manager ID: {Eid}");
    //        Console.WriteLine($"Manager Name: {Ename}");
    //        Console.WriteLine($"Manager Salary: {Salary}");
    //        Console.WriteLine($"Manager Bonus: {Bonus}");
    //    }
    //}
    //Further No Inheritance is Possible as we marked the class as sealed
    //public class TempManager : Manager
    //{
    //}

    //Sealed Method

    //we can override

    //class Parent
    //{
    //    public virtual void Show() { }
    //}
    //class Child : Parent
    //{
    //    public override void Show() { }
    //}
    //class GrandChild : Child
    //{
    //    public override void Show() { }
    //}

    //But if we want to stop override

    //class Parent
    //{
    //    public virtual void Show() { }
    //}
    //class Child : Parent
    //{
    //    public sealed override void Show() { }
    //}
    //class GrandChild : Child
    //{
    //    //'GrandChild.Show()': cannot override inherited member 'Child.Show()' because it is sealed
    //    public override void Show() { }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Manager m1 = new Manager();
    //        //m1.GetEmployeeData();
    //        //m1.DisplayEmployeeData();
    //        //Console.ReadKey();
    //    }
    //}

    //Real time example
    //public class Printer
    //{
    //    //The Printer class declaring two virtual methods
    //    public virtual void Display()
    //    {
    //        Console.WriteLine("Display Dimension: 5x5");
    //    }
    //    public virtual void Print()
    //    {
    //        Console.WriteLine("Printer Printing...\n");
    //    }
    //}
    //public class LaserJet : Printer
    //{
    //    //The LaserJet class Overriding the two parent class virtal methods
    //    //But making the Display method as sealed, so the child classes of LaserJet class
    //    //will not override this method
    //    public sealed override void Display()
    //    {
    //        Console.WriteLine("Display Dimension: 10x10");
    //    }
    //    //The Print method can be override under the Child class of LaserJet class
    //    public override void Print()
    //    {
    //        Console.WriteLine("LaserJet Printer Printing...\n");
    //    }
    //}
    //The InkJet class can not override the Display Method as it is marked sealed in LaserJet class.
    //So, InkJet will have same Display feature i.e it also has "Display Dimention: 10x10".
    //public sealed class InkJet : LaserJet
    //{
    //    //The following method overriding will give compile time error
    //    //'InkJet.Display()': cannot override inherited member 'LaserJet.Display()' because it is sealed
    //    //public override void Display()
    //    //{
    //    //    Console.WriteLine("Some Different Display Dimension");
    //    //}
    //    public override void Print()
    //    {
    //        Console.WriteLine("InkJet Printer Printing...");
    //    }
    //}
    //As we marked the InkJet class as sealed so more inheritance using InkJet class
    //The following inheritance will give you compile time error
    //'DotMatrix': cannot derive from sealed type 'InkJet'
    //class DotMatrix : InkJet
    //{
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Printer printer = new Printer();
    //        printer.Display();
    //        printer.Print();
    //        LaserJet laserJet = new LaserJet();
    //        laserJet.Display();
    //        laserJet.Print();
    //        InkJet inkJet = new InkJet();
    //        inkJet.Display();
    //        inkJet.Print();
    //        Console.ReadLine();
    //    }
    //}

    //What is the difference between the private and sealed methods in C#?
    public class Class1
    {
        public virtual void Method1()
        {
            Console.WriteLine("Class1 Method1");
        }
    }
    public class Class2 : Class1
    {
        //Private Method
        private void Method2()
        {
            Console.WriteLine("Class2 Private Method2");
        }
        //Sealed Method
        public sealed override void Method1()
        {
            Console.WriteLine("Class2 Sealed Method1");
        }
    }

    public class Class3 : Class2
    {
        //We cannot override Method1 because it is sealed in Class2
        //But this method is inherited and hence we can access this method
        //using Class3 instance
        //public override void Method1()
        //{
        //    Console.WriteLine("InkJet Printer Printing...");
        //}
        //Class2 Private Method Method2 is not inherited to child class and hence
        //you can define the same method here
        public void Method2()
        {
            Console.WriteLine("Class3 public Method2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class2 obj1 = new Class2();
            obj1.Method1();
            Class3 obj3 = new Class3();
            obj3.Method1();
            obj3.Method2();
            Console.ReadLine();
        }
    }

}
