using System;

namespace Budget
{
    public class StartingBalance
    {
        public decimal _balance;
        public decimal GetStartingBalance ()
        {
            Console.WriteLine("The starting balance must be greater that zero.");
            Console.Write("Enter your starting balance: ");
            decimal _balance = Decimal.Parse(Console.ReadLine());


            //TODO enter validation for starting balance
            return _balance;
        }
    }
}
