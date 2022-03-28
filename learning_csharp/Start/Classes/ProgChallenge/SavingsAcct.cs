using System;
namespace ProgChallenge
{
    class SavingsAcct : BankAccount
    {
        private int _withdrawalCount = 0;
        private const decimal WITHDRAW_CHRAGE = 2.00m;
        private const int WITHDRAW_LIMIT = 3;
        public SavingsAcct(string firstName, string lastName, decimal interest, decimal balance)
        : base(firstName, lastName, balance)
        {
            InterestRate = interest;
        }
        public decimal InterestRate
        {
            get; set;
        }

        public void ApplyInterest()
        {
            Balance = Balance * (1 + InterestRate);
        }
        public override void Withdraw(decimal d)
        {
            decimal extraFees = 0m;

            if (d > Balance)
            {
                Console.WriteLine("Attempt to overdraw savings - denied");
                return;
            }
            else
            {
                _withdrawalCount++;
                if (_withdrawalCount > WITHDRAW_LIMIT)
                {
                    Console.WriteLine("Too many withdrawls, extra fees apply");
                    extraFees += WITHDRAW_CHRAGE;
                }
                base.Withdraw(d + extraFees);
            }

        }
    }
}