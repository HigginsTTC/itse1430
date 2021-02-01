using System;

namespace Budget
{
    public class AccountNumber
    {
        public string _accountNumber;

        public string GetAccountNumber ()
        {
            Console.Write("Enter your account number: ");
            string _accountNumber = Console.ReadLine();

            return _accountNumber;
        }
    }
}
