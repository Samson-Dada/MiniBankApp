using System;
using System.Linq;

namespace MiniBankApp
{
    internal class Program
    {
        static void Main()
        {
            AccountDetails anAccountDetails = new AccountDetails();
            while (true)
            {
                string number = Console.ReadLine();
                var user = anAccountDetails.BankUsers.Where(u => u.BankAccount.Number == number).FirstOrDefault();
                Console.WriteLine($"User with name {user.FirstName} {user.LastName} has {user.BankAccount.Balance}");
            }
        }
    }
}
