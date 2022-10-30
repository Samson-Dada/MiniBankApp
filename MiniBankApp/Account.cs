using System;

namespace MiniBankApp
{
    public class Account: BankUser
    {
        public Account(decimal initialDeposit = 0)
        {
            Balance = 1000 + initialDeposit;
           
            Number = $"07{DateTime.Now.ToString("yyMMdd")}{new Random().Next(99).ToString().PadLeft(5, '0')}";
            Console.WriteLine($"Your Account number: {Number.ToString()}");
            Console.WriteLine($"With minimum account opening balance: {Balance}");
            Console.WriteLine($"Account created successfuly with opening balance : Your {FirstName}, {LastName}, {BankAccount.Balance} {BankAccount.Email}");
        }

       
        public string Number { get; set; }
        public decimal Balance { get; set; }
        public string TransactionPin { get; set; }

    }
}