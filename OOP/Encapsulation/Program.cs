using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Contents:

//What is Encapsulation ?
//How can we Implement Encapsulation in C#?
//Encapsulation Examples using Setter and Getter Methods
//What are the Advantages of Providing Variable Access via Setter and Getter Methods in C#?
//What is the Problem if we don’t follow Encapsulation Principle in C# while Designing a Class
//Implementing Encapsulation in C# using Properties

//“Encapsulation Hides the internal state and functionality of an object and only allows access through a public set of functions“. 
//Every class, interface, struct, enum, etc. that we created is an example of encapsulation

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Bank bank = new Bank();
                //bank.AccountNumber = 1604045;
                //bank.Name = "Faridul Islam";
                //bank.Balance = "10";
                //bank.Withdraw = 5;
                //bank.DepositMoney = 10;
                //bank.GetBalance();
                //bank.WithdrawAmount();

                //Getter and Setter Method
                //bank.SetBalance(500);
                //Console.WriteLine(bank.GetBalance());

                //bank.SetBalance(10.6);
                //Console.WriteLine(bank.GetBalance());

                //Much easier way to implement Getter and Setter Method
                //Console.WriteLine("Enter amount");
                //double input = double.Parse(Console.ReadLine());

                bank.Amount = 6;
                Console.WriteLine(bank.Amount);
                //if (input > 0)
                //{
                //    Console.WriteLine("Okay");
                //    Console.ReadLine();
                //    break;
                //}

                bank.Amount = 2;
                Console.WriteLine(bank.Amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }

}

//Advantages of Encapsulation in C#:

//Protection of data: You can validate the data before storing it in the variable.
//Achieving Data Hiding: The user will have no idea about the inner implementation of the class.
//Security: The encapsulation Principle helps to secure our code since it ensures that other units
//    (classes, interfaces, etc) can not access the data directly.
//Flexibility: The encapsulation Principle in C# makes our code more flexible,
//    which in turn allows the programmer to change or update the code easily.
//Control: The encapsulation Principle gives more control over the data stored
//    in the variables. For example, we can control the data by validating whether the data is good enough to store in the variable.