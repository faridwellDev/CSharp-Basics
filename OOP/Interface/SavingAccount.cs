using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    //Real time exmaple of interface
    public class SavingAccount : IBankAccount
    {
        private decimal Balance = 0;
        private readonly decimal PerDayWithdrawLimit = 10000;
        private decimal TodayWithdrawl = 0;

        public bool DepositAmount(decimal Amount)
        {
            Balance = Balance + Amount;
            Console.WriteLine($"You have Deposited: {Amount}");
            Console.WriteLine($"Your Account Balance: {Balance}");
            return true;
        }

        //Maximum Withdrawl Per Day: 10000
        public bool WithdrawAmount(decimal Amount)
        {
            if (Balance < Amount)
            {
                Console.WriteLine("You have insufficient balance!");
                return false;
            }
            else if (TodayWithdrawl + Amount > PerDayWithdrawLimit)
            {
                Console.WriteLine("Withdrawl attempt failed!");
                return false;
            }
            else
            {
                Balance = Balance - Amount;
                TodayWithdrawl = TodayWithdrawl + Amount;
                Console.WriteLine($"You have successfully Withdraw: {Amount}");
                Console.WriteLine($"Your Account Balance: {Balance}");
                return true;
            }
        }
        public decimal CheckBalance()
        {
            return Balance;
        }
    }
}
