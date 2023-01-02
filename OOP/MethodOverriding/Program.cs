using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{

    //Method Overriding Real-Time Example in C#

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }

        public virtual double CalculateBonus(double Salary)
        {
            return 50000;
        }
    }

    public class Developer : Employee
    {
        //50000 or 20% Bonus to Developers which is greater
        public override double CalculateBonus(double Salary)
        {
            double baseSalary = base.CalculateBonus(Salary);
            double calculateSalary = Salary * .20;
            if(baseSalary >= calculateSalary)
            {
                return baseSalary;
            }
            else
            {
                return calculateSalary;
            }
        }
    }

    public class Manager : Employee
    {
        //50000 or 25% Bonus to Developers which is Greater
        public override double CalculateBonus(double Salary)
        {
            double baseSalary = base.CalculateBonus(Salary);
            double calculateSalary = Salary * .25;
            if (baseSalary >= calculateSalary)
            {
                return baseSalary;
            }
            else
            {
                return calculateSalary;
            }
        }
    }

    public class Admin : Employee
    {
        //return fixed bonus 50000
        //no need to override the method
    }
    //Overriding the virtual Method is Optional
    //class Class1
    //{
    //    public virtual void Show()
    //    {
    //        Console.WriteLine("Parent Class show Method");
    //    }
    //}
    //class Class3 : Class1
    //{

    //    ////Using the base keyword to call the Parent Class methods
    //    //public override void Show()
    //    //{
    //    //    base.Show(); //Calling Parent Class show Method
    //    //    Console.WriteLine("Child Class Show Method");
    //    //}

    //    //Output: Parent Class show Method
    //    //Child Class Show Method
    //    //Parent Class show Method
    //    //Child Class Show Method

    //    //Calling Parent Class Methods by creating the Parent Class Object under the Child Class

    //    //public override void Show()
    //    //{
    //    //    //Calling an instance of Parent Class
    //    //    Class1 class1 = new Class1();
    //    //    //Calling Parent Class Show Method
    //    //    class1.Show();
    //    //    Console.WriteLine("Child Class Show Method");
    //    //}

    //    //Output: Parent Class show Method
    //    //Child Class Show Method
    //    //Parent Class show Method
    //    //Child Class Show Method
    //}

    class Program
    {

        //Real-time Example
        static void Main(string[] args)
        {
            Employee emp1 = new Developer
            {
                Id = 1604045,
                Name = "Sachin",
                Salary = 500000,
                Designation = "Developer"
            };
            double bonus = emp1.CalculateBonus(emp1.Salary);
            Console.WriteLine($"Name: {emp1.Name}, Designation: {emp1.Designation}, Salary: {emp1.Salary}, Bonus: {bonus}");
            Console.WriteLine();

            Employee emp2 = new Manager
            {
                Id = 1604046,
                Name = "Ramesh",
                Salary = 800000,
                Designation = "Manager"
            };
            bonus = emp2.CalculateBonus(emp2.Salary);
            Console.WriteLine($"Name: {emp2.Name}, Designation: {emp2.Designation}, Salary: {emp2.Salary}, Bonus: {bonus}");
            Console.WriteLine();

            Employee emp3 = new Admin
            {
                Id = 1604044,
                Name = "Rajib",
                Salary = 300000,
                Designation = "Admin"
            };
            bonus = emp3.CalculateBonus(emp3.Salary);
            Console.WriteLine($"Name: {emp3.Name}, Designation: {emp3.Designation}, Salary: {emp3.Salary}, Bonus: {bonus}");
            Console.WriteLine();

            Employee emp4 = new Developer
            {
                Id = 1604043,
                Name = "Priyanka",
                Salary = 200000,
                Designation = "Developer"
            };
            bonus = emp4.CalculateBonus(emp4.Salary);
            Console.WriteLine($"Name: {emp4.Name}, Designation: {emp4.Designation}, Salary: {emp4.Salary}, Bonus: {bonus}");
            Console.WriteLine();

            Employee emp5 = new Admin
            {
                Id = 1604032,
                Name = "Shafkat",
                Salary = 40000,
                Designation = "Admin"
            };

            bonus = emp5.CalculateBonus(emp5.Salary);
            Console.WriteLine($"Name: {emp5.Name}, Designation: {emp5.Designation}, Salary: {emp5.Salary}, Bonus: {bonus}");

            Console.ReadLine();
        }

        //Output: 
        //        Name: Sachin, Designation: Developer, Salary: 500000, Bonus: 100000

        //Name: Ramesh, Designation: Manager, Salary: 800000, Bonus: 200000

        //Name: Rajib, Designation: Admin, Salary: 300000, Bonus: 50000

        //Name: Priyanka, Designation: Developer, Salary: 200000, Bonus: 50000
        //........................................................................................................................................................

        //static void Main(string[] args)
        //{
        //    Class3 obj3 = new Class3();
        //    obj3.Show();

        //    Class1 obj4 = new Class3();
        //    obj4.Show();

        //    Console.ReadLine();
        //}
    }



    ////Virtual Function (Overridable Method)
    //class Class1
    //{
    //    public virtual void Show()
    //    {
    //        //Parent Class Logic Same for All Child Classes
    //        Console.WriteLine("Parent class show method");
    //    }
    //}
    //class Class2 : Class1
    //{
    //    //Overriding Method
    //    public override void Show()
    //    {
    //        Console.WriteLine("Child Class Show Method");
    //    }
    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Class1 obj = new Class2();
    //        obj.Show();

    //        Class2 obj2 = new Class2();
    //        obj2.Show();
    //        Console.ReadLine();
    //    }
    //}

    //Class1 => Reference Variable obj1 type
    //Class2 => Reference Variable obj1 pointing the object whose type is Class2
    //obj.Show()
    //obj => Reference Variable Type = Class1
    //obj => Pointing to object whose type = Class2

    //Compilation => Compiler will check the reference variable type
    //Runtime => CLR will check the object type
}
