using System;

namespace MiniBankApp
{
    public class AccountOperationMenu : Account{



        public void AccountOperation()
        {
            Console.WriteLine("Enter 1 for Withdrawl, 2 for Deposit, 3 for Logout, 4 for login");
            string StringMenu = Console.ReadLine();
            int NextOption = Convert.ToInt32(StringMenu);
            switch (NextOption)
            {
                case 1:
                    Deposit();
                    break;
                case 2:
                    // Withdraw();
                    break;
                case 3:
                    // Logout();
                    break;

            }
        }
              public decimal Deposit()
            {
                Console.WriteLine("Available Balance: {0}", BankAccount.Balance);
                Console.WriteLine("How much would you like to deposit?: ");
                var DepositAmount = Convert.ToDecimal(Console.ReadLine());

                 var x = base.Number = DepositAmount.ToString();

                x += DepositAmount;
                Console.WriteLine(BankAccount.Balance);
                AccountOperation();
                return DepositAmount;
            
        
        
              }






    }
}
