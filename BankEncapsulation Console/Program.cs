using System;

namespace BankEncapsulation_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var BankAccount = new BankAccount();

            Console.WriteLine("How much money do you want to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            BankAccount.Deposit(amountToDeposit);

            double userBalance = BankAccount.GetBalance();

            Console.WriteLine($"Your current balance is {amountToDeposit,0}");
                
        }
    }
}
