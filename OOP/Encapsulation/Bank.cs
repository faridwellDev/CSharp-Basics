using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Bank
    {
        //public long AccountNumber;
        //public string Name;
        //public string Balance;
        //public int Withdraw;
        //public int DepositMoney;

        //Getter and Setter Method
        //private double balance;

        ////public Getter Method
        ////This method is used to return the data stored in the balance variable
        //public double GetBalance()
        //{
        //    //add validation logic if needed
        //    return balance;
        //}

        ////Public Setter Method
        ////This method is used to stored the data in the bank varible
        //public void SetBalance(double balance)
        //{
        //    if (balance > 0)
        //    {
        //        this.balance = balance;
        //    }
        //    else
        //    {
        //        throw new Exception("Please Pass a Positive Value");
        //    }
        //}

        //Much easier way to implement Getter and Setter Method
        private double _Amount;
        public double Amount
        {
            get { return _Amount; }
            set
            {
                if (value < 0) { throw new Exception("Please Pass a Positive Value"); }
                else
                {
                    _Amount = value;
                }

            }
            //public void GetBalance()
            //{
            //    Console.WriteLine("Total balance: " + Balance);
            //}
            //public void WithdrawAmount()
            //{
            //    Console.WriteLine("Withdraw amount: " + Withdraw);
            //}
            //public void Deposit()
            //{
            //    Console.WriteLine("Deposit: " + DepositMoney);
            //}
        }
    }
}
