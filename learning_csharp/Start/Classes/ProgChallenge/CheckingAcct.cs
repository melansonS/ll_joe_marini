using System;
namespace ProgChallenge
{
    class CheckingAcct : BankAccount
    {
        private const decimal OVERDRAW_CHARGE = 35.00m;
        public CheckingAcct(string firstName, string lastName, decimal balance)
        : base(firstName, lastName, balance)
        {

        }

        public override void Withdraw(decimal d)
        {
            if (d > Balance)
            {
                d += OVERDRAW_CHARGE;
            }
            base.Withdraw(d);
        }
    }
}