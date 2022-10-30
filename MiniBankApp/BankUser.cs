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
                    return _email;
                }
                else
                {
                    throw new Exception("Email is not valid");
                }
              
            }
            set
            {
                _email = value;
            }
        }
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
