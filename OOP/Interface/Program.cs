using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Interface
{
    //How to implement Each Interfaces Method Seperately
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        MultipleInheritanceTest obj = new MultipleInheritanceTest();
    //        obj.Test();

    //        //using Interface Referance call the Show Method
    //        Interface1 i1 = obj;
    //        i1.Show();

    //        Interface2 i2 = obj;
    //        i2.Show();

    //        Console.ReadLine();
    //    }
    //}
    //public interface Interface1
    //{
    //    void Test();
    //    void Show();
    //}
    //public interface Interface2
    //{
    //    void Test();
    //    void Show();
    //}
    //public class MultipleInheritanceTest : Interface1, Interface2
    //{
    //    //Normal Implementation
    //    public void Test()
    //    {
    //        Console.WriteLine("Test Method is Implemented in Child Class");
    //    }

    //    //Explicit Interface Implementaion
    //    void Interface1.Show()
    //    {
    //        Console.WriteLine("Interface1 show method is implemented in Child Class");
    //    }

    //    //Explicit Interface Implementation
    //    void Interface2.Show()
    //    {
    //        Console.WriteLine("Interface2 Show Method is Implemented in Child Class");
    //    }
    //}

    //Real-Time Example of Interface
    interface IBankAccount
    {
        bool DepositAmount(decimal Amount);
        bool WithdrawAmount(decimal Amount);
        decimal CheckBalance();

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saving Account:");
            IBankAccount savingAccount = new SavingAccount();
            savingAccount.DepositAmount(2000);
            savingAccount.DepositAmount(1000);
            savingAccount.WithdrawAmount(1500);
            savingAccount.WithdrawAmount(5000);
            Console.WriteLine($"Saving Account Balance: {savingAccount.CheckBalance()}");

            Console.WriteLine("\nCurrent Account:");
            IBankAccount currentAccount = new CurrentAccount();
            currentAccount.DepositAmount(500);
            currentAccount.DepositAmount(1500);
            currentAccount.WithdrawAmount(2600);
            currentAccount.WithdrawAmount(1000);
            Console.WriteLine($"Current Account Balance: {currentAccount.CheckBalance()}");
            Console.ReadLine();

            //Exmaple of Interface
            //ITestInterface1 obj = new ImplementationClass1();
            //obj.Add(10, 20);

            ////We cannot call Sub method
            ////obj1.Sub(100, 20)

            //ImplementationClass2 obj2 = new ImplementationClass2();
            ////Using obj2 we can call both Add and Sub method
            //obj2.Add(10, 20);
            //obj2.Sub(20, 30);
            //..............................................................................................

            //5-> Creating Reference of an interface point to the
            //Child class interface

            //ITestInterface1 obj = new ImplementationClass1();

            ////Add method signature declared in ITestInterface1, so we can
            ////Invoke the Add method
            //obj.Add(10, 20);

            ////Sub method signature is not declared in ITestInterface1,
            ////so, we cannot Invoke the sub method
            ////obj.Sub(100, 20)
            //...............................................................................................

            //Explicit Implementation
            //ImplementationClass2 obj = new ImplementationClass2();

            ////Implementation using public access specifier
            //obj.Add(10, 20);

            ////We need to typecase obj to IntestInterface1 to call the sub
            ////method because sub method is implemented using interface name
            //((ITestInterface2)obj).Sub(100, 20);

            ////Even we can call the method directly using the interface reference
            ////Typecasting is not required in this case
            //ITestInterface2 obj1 = new ImplementationClass2();
            //obj1.Add(10, 20);
            //obj1.Sub(100, 50);

            //Console.ReadLine();
        }
    }
    ////Explicit interface implementation
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    
    //    }
    //}

    //4-> Example of interface + 5->
    //interface ITestInterface1
    //{
    //    void Add(int num1, int num2);
    //    //void Sub(int v1, int v2);
    //}
    //interface ITestInterface2 : ITestInterface1
    //{
    //    void Sub(int num1, int num2);
    //}

    //public class ImplementationClass1 : ITestInterface1
    //{
    //    //Implement only the Add method
    //    public void Add(int num1, int num2)
    //    {
    //        Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
    //    }
    //}
    //public class ImplementationClass2 : ITestInterface2
    //{
    //    //Normal Implementation of Interface Method
    //    public void Add(int num1, int num2)
    //    {
    //        Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
    //    }
    //    //Explicit Implementation of Interface Method
    //    void ITestInterface2.Sub(int num1, int num2)
    //    {
    //        Console.WriteLine($"Divison of {num1} and {num2} is {num1 - num2}");
    //    }
    //    public void Sub(int num1, int num2)
    //    {
    //        Console.WriteLine($"Divison of {num1} and {num2} is {num1 - num2}");
    //    }
    //}
}
