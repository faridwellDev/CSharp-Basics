using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Abstract Methods:  There are no dimensions for shape. It’s a generalized term. So, this is an example of Generalization in C#.
//No, don’t think that an abstract class can contain only abstract methods. It can also contain non-abstract methods. The point
//that you need to remember is, that if a class is non-abstract then it contains only non-abstract methods but if a class is
//abstract then it contains both abstract and non-abstract methods in C#.
namespace Abstraction

{
    //The process of representing the essential features without including the background details is called Abstraction
    //Abstraction lets you focus more on what an object does rather than how it does.
    internal class Program
    {
        static void Main(string[] args)
        {
            //How can we execute static and non-static concrete members of the abstract class?

            //AbsParent.StaticMethod();

            //AbsChild absChild = new AbsChild();
            ////Calling the Abstract Class Concrete Method using Child class Object
            //absChild.NonStaticMethod();

            ////calling the Abstract method usign Child Class object
            //absChild.AbstractMethod();

            //Console.ReadLine();

            //4->Example to implement abstraction using interface

            Console.WriteLine("Transaction doing SBI Bank");
            IBank sbi = BankFactory.GetBankObject("SBI");
            sbi.ValidateCard();
            sbi.WithdrawMoney();
            sbi.CheckBalance();
            sbi.BankTransfer();
            sbi.MiniStatement();

            Console.WriteLine("\nTransaction doing AXIX Bank");
            IBank aXIX = BankFactory.GetBankObject("AXIX");
            aXIX.ValidateCard();
            aXIX.WithdrawMoney();
            aXIX.CheckBalance();
            aXIX.BankTransfer();
            aXIX.MiniStatement();

            Console.ReadLine();
        }
    }
    //public abstract class AbsParent
    //{
    //    //Static Method
    //    public static void StaticMethod()
    //    {
    //        Console.WriteLine("Static Method");
    //    }

    //    //Non-Static Method
    //    public void NonStaticMethod()
    //    {
    //        Console.WriteLine("Non-Static Method");
    //    }

    //    //Abstract Method
    //    public abstract void AbstractMethod();
    //}

    //public class AbsChild : AbsParent
    //{
    //    public override void AbstractMethod()
    //    {
    //        Console.WriteLine("AbstractMethod Implemented in Child Class.");
    //    }
    //}

    //3-> Implementing abstraction using interface method
    //public interface IBank
    //{
    //    void ValidateCard();
    //    void WithdrawMoney();
    //    void CheckBalance();
    //    void BankTransfer();
    //    void MiniStatement();

    //}
    //.......................................................................................................
    //Implementing abstraction using abstract class and methods

    public abstract class IBank
    {
        public abstract void ValidateCard();
        public abstract void WithdrawMoney();
        public abstract void CheckBalance();
        public abstract void BankTransfer();
        public abstract void MiniStatement();
    }
    public class BankFactory
    {
        public static IBank GetBankObject(string bankType)
        {
            IBank BankObject = null;
            if (bankType == "SBI")
            {
                BankObject = new SBI();
            }

            else if (bankType == "AXIX")
            {
                BankObject = new aXIX();
            }
            return BankObject;
        }
    }
    public class SBI : IBank
    {
        public override void BankTransfer() //we avoid override for interface bcz it doesn't need to inlcude excludely
        {
            Console.WriteLine("SBI Bank Bank Transfer");
        }

        public override void CheckBalance()
        {
            Console.WriteLine("SBI Bank Check Balance");
        }

        public override void MiniStatement()
        {
            Console.WriteLine("SBI Bank Mini Statement");
        }

        public override void ValidateCard()
        {
            Console.WriteLine("SBI Bank Validate Card");
        }

        public override void WithdrawMoney()
        {
            Console.WriteLine("SBI Bank Withdraw Money");
        }
    }

    public class aXIX : IBank
    {
        public override void BankTransfer()
        {
            Console.WriteLine("AXIX Bank Bank Transfer");
        }

        public override void CheckBalance()
        {
            Console.WriteLine("AXIX Bank Check Balanace");
        }
        public override void MiniStatement()
        {
            Console.WriteLine("AXIX Bank Mini Statement");
        }
        public override void ValidateCard()
        {
            Console.WriteLine("AXIX Bank Validate Card");
        }
        public override void WithdrawMoney()
        {
            Console.WriteLine("AXIX Bank Withdraw Money");
        }
    }
}


//Advantages of Abstraction Principle in C#

//The Abstraction Principle reduces the complexity of viewing things.
//It only provides the method signature by hiding how the method is actually implemented.
//The Abstraction Principle helps to increase the security of an application or program
//as we are only providing the necessary details to call the method by hiding how the methods are actually implemented.
//With the Abstraction Principle, the enhancement will become very easy because without
//affecting end-users we can able to perform any type of changes in our internal system.
//Without the Abstraction principle, maintaining application code is very complex.
//Abstraction gives one structure to program code.


//Summary of Abstract Class and Abstract Methods
//A method that does not have a body is called an abstract method and the class that is declared by using the
//    keyword abstract is called an abstract class. If a class contains an abstract method, then it must be declared as abstract.
//An abstract class can contain both abstract and non-abstract methods.If a child class of an abstract
//    class wants to consume any non-abstract methods of its parent, should implement all abstract methods of its parent.
//An abstract class is never usable to itself because we cannot create the object of an abstract class. The members
//    of an abstract class can be consumed only by the child class of the abstract class.

//A class should be declared as abstract
//Case 1: If the class has any abstract methods, then we need to declare the class as abstract.
//Case 2: If the child does not provide implementation to any of the parent abstract methods, then again, the child class needs to be declared as an abstract class.
//Case 3: If the child class does not provide implementation to any of the methods of an interface, then the child class needs to be declared as an abstract class
//as well as needs to declare the method as abstract. 

//When to use the Abstract Method in C#?
//Abstract methods are usually declared where two or more subclasses are expected to fulfill a similar role in a different manner.
//    You can also do the same thing using an interface also. But if we are using an abstract class means we can provide some common 
//    functionality that is going to be the same for all the child classes and this is not possible using the interface.

//Static members can be executed directly by using the class name and its non-static members are executed by using its concrete sub-class or child class object. 

//Can we Declare an Abstract Method as Static in C#? No, We are not allowed to declare an abstract method as static

//What are the Members we can and can’t define in an interface in C#?
//An interface can contain

//Abstract methods
//Properties
//Indexes
//Events
//An interface cannot contain

//Non-abstract functions
//Data fields
//Constructors
//Destructors