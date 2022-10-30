using System;
using System.Text.RegularExpressions;

namespace MiniBankApp

{
    public class BankUser
    {
        public string _firstName;
        public string _lastName;
        public string _email;
        public string _password;
        public string _pin;
        public string _bankAccount;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }




        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        
        public string Email
        {

            get
            {
                if (IsValid(_email))
                    {
                    Console.WriteLine("email is valid");
                }
                else
                {
                    Console.WriteLine("email is not valid");
                }
                return _email;
            }

            set
            {
                _email = value;
            }
        }
        //public void ValidateEmail()
        //{
        //    //Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        //    string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";
        //    Match match = regex.Match(email);
        //    if (_email = IsValid(_email))
        //            {
        //        Console.WriteLine("email is valid");
        //    }
        //    else
        //    {
        //        Console.WriteLine("email is not valid");

        //    }
        
        //}
        private static bool IsValid(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }
        public string Password { get; set; }
        public string TranasactionPin { get; set; }
        public string Number { get; set; }
        public Account BankAccount {get; set;}
        
    }
}
