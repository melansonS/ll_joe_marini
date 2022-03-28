using System;
namespace ProgChallenge
{
    class SavingsAcct : Account
    {
        private decimal _interest;
        private int _withdrawalCount = 0;
        public SavingsAcct(string firstName, string lastName, decimal interest, decimal balance)
        : base(firstName, lastName, balance)
        {
            _interest = interest;
        }

        public void ApplyInterest()
        {
            _balance = Balance * (1 + _interest);
        }
        public override void Withdraw(decimal d)
        {
            _withdrawalCount++;
            decimal extraFees = 0m;

            if (d > Balance)
            {
                Console.WriteLine("Attempt to overdraw savings - denied");
                return;
            }

            if (_withdrawalCount > 3)
            {
                Console.WriteLine("Too many withdrawls, extra fees apply");
                extraFees += 2.00m;
            }
            base.Withdraw(d + extraFees);
        }
    }
}