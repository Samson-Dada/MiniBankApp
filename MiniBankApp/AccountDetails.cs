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
            Console.Write("FirstName: ");
            var firstName = FirstName = Console.ReadLine();
            Console.Write("LastName: ");
            var lastName = LastName = Console.ReadLine();
            Console.Write("Email: ");
            var email = Email = Console.ReadLine();

            if (firstName == "" || lastName == "" || email == "")
            {
                Console.WriteLine("Error in account process, enter correct information");
            }
            else
            {
                BankUsers = new List<BankUser>()
            {
               new BankUser()
               {
               FirstName = _firstName,
               LastName = _lastName,
               BankAccount = new Account(),
               }
            };
            }
        }
       public List<BankUser> BankUsers { get; set; }
    }
}
