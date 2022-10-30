using System;
using System.Linq;

namespace MiniBankApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("1: Enter Your name below: (FirstName) and (LastName)");
            Console.WriteLine("2: Set your password");
            Console.WriteLine("3: Set your pin");
            Console.WriteLine("4: Enter Your email address");
            AccountDetails anAccountDetails = new AccountDetails();
            Account account = new Account();
            while (true)
            {
                string number = Console.ReadLine();
                var user = anAccountDetails.BankUsers.Where(u => u.BankAccount.Number == number).FirstOrDefault();
                Console.WriteLine($"User with name {user.FirstName} {user.LastName} has {user.BankAccount.Balance}");
            }
        }
    }
}
