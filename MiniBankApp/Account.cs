using System;

namespace MiniBankApp
{
    public class Account: BankUser
    {
        public Account(decimal initialDeposit = 0)
        {
            Balance = 1000 + initialDeposit;
            Console.WriteLine("1: Enter Your name below: (FirstName) and (LastName)");
            Console.WriteLine("2: Set password");
            Console.WriteLine("3: Set pin");
            Console.WriteLine("4: Enter Your email address");
            Number = $"07{DateTime.Now.ToString("yyMMdd")}{new Random().Next(99).ToString().PadLeft(5, '0')}";
            Console.WriteLine($"Account number:{IsAccountNumber(Number)}");
            Console.WriteLine($"Minimum account opening balance: {Balance}");
        }

       public bool IsAccountNumber(string accountNumber)
        {
            if(FirstName  != null && LastName != null)
            {
                Console.WriteLine("Enter your account name");

            }

            return true;
        }
        public string Number { get; set; }
        public decimal Balance { get; set; }
        public string TransactionPin { get; set; }

    }
}