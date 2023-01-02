using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassMethods
{
    //Partial Method
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        PartialClass SC = new PartialClass();
    //        SC.PublicMethod();
    //        Console.ReadLine();
    //    }
    //}

    //Rule 1:
    //partial class PartialClass
    //{
    //    protected partial void PartialMethod();
    //}

    //Rule 2: 
    //partial class PartialClass
    //{
    //    partial void PartialMethod()
    //    {
    //        Console.WriteLine("Hi there!");
    //    }
    //}

    //Rule 3:
    //partial class PartialClass
    //{
    //    partial int PartialMethod();
    //}

    //Rule 4:
    //public class PartialClass
    //{
    //    partial void PartialMethod();
    //}

    //Rule 5:
    //public partial class PartialClass
    //{
    //    partial void PartialMethod(int x);
    //}
    //public partial class PartialClass
    //{
    //    partial void PartialMethod()
    //    {
    //        //Implementation
    //    }
    //}

    //Rule 6:
    //public partial class PartialClass
    //{
    //    partial void PartialMethod();
    //}
    //public partial class PartialClass
    //{
    //    partial void PartialMethod()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //public partial class PartialClass
    //{
    //    partial void PartialMethod()
    //    {

    //    }
    //}
    
    //..............................................................................................................................................
    //Partial Class 5 Rules:
    //Rule 1:
    //public partial class PartialEmployee1
    //{

    //}
    //public class PartialEmployee1
    //{
    //    public void Display()
    //    {

    //    }
    //    public void DisplayEmployeeDetail()
    //    {

    //    }
    //}
    //Rule 2:

    //public partial class PartialEmployee1
    //{

    //}
    //internal partial class PartialEmployee1
    //{
    //    public void Display()
    //    {

    //    }
    //    public void DisplayEmployeeDetail()
    //    {

    //    }
    //}

    //Rule 3:
    //public abstract partial class PartialEmployee1
    //{

    //}
    //public partial class PartialEmployee1
    //{
    //    public void Display()
    //    {

    //    }
    //    public void DisplayEmployeeDetail()
    //    {

    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        PartialEmployee1 emp = new PartialEmployee1();
    //    }
    //}

    //Rule 4: 
    //public class Employee
    //{

    //}
    //public class Customer
    //{

    //}
    //public partial class PartialClass : Employee
    //{

    //}
    //public partial class PartialClass : Customer
    //{

    //}

    //Rule 5:
    //public interface IEmployee
    //{
    //    void EmployeeMethod();
    //}
    //public interface ICustomer
    //{
    //    void CustomerMethod();
    //}
    //public partial class PartialClass : IEmployee
    //{
    //    public void EmployeeMethod()
    //    {
    //        //Method Implementation
    //    }
    //}
    //public partial class PartialClass : ICustomer
    //{
    //    public void CustomerMethod()
    //    {
    //        //Method Implementation
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        PartialEmployee emp = new PartialEmployee()
    //        {
    //            FirstName = "Well",
    //            LastName = "Dev",
    //            Salary = 100000,
    //            Gender = "Male"
    //        };
    //        emp.DisplayFullName();
    //        emp.DisplayEmployeeDetails();
    //        Console.ReadLine();
    //    }
    //    //Output : Full Name is : Well Dev
    //    //Employee Details:
    //    //First Name:  Well
    //    //Last Name: Dev
    //    //Gender: Male
    //    //Salary: 100000
    //}


}
