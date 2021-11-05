using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation_Console
{
    class BankAccount
    {
        private double balance = 0;

        public void Deposit(double amount)
        {
            Console.WriteLine($"Getting a deposit of {amount,0} to your account!!!");
        }

        public double GetBalance()
        {
            return balance;
        }
        
  
    }
}
