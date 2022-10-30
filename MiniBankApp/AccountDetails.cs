using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankApp 
{

    public class AccountDetails : BankUser {


        public AccountDetails()
        {
            BankUsers = new List<BankUser>()
            {
               // new BankUser()
               //{
               //FirstName = "Tina",
               //LastName = "Ben",
               //Email = "benson12@gmail.com",
               //BankAccount = new Account(5000)
               //},
               new BankUser()
               {
               FirstName = _firstName,
               LastName = _lastName,
               BankAccount = new Account(),
               }
            };


            /*
             *  check if account has name and minimum deposit
             *  write a condtion to check if a there is name and inital deposte 
             *  before account creation;
             */
            Console.Write("FirstName: ");
            var firstName = FirstName = Console.ReadLine();
            Console.Write("LastName: ");
            var lastName = LastName = Console.ReadLine();
            Console.Write("Email: ");
            var email = Email = Console.ReadLine();

            //Console.WriteLine( $"Your Account Details: {firstName}, {lastName} {BankAccount} {Number}");
            Console.WriteLine($"Account created successfuly with opening balance : Your {FirstName}, {LastName}, {BankAccount.Balance} {BankAccount.Email}");
            Console.ReadLine();
        }
       public List<BankUser> BankUsers { get; set; }
    }
}
