using System;

namespace Budget
{
    public class StartingBalance
    {
        public decimal _balance;
        public decimal GetStartingBalance ()
        {
            Console.Write("Enter your starting balance: ");
            decimal _balance = Decimal.Parse(Console.ReadLine());

            return _balance;
        }
    }
}
