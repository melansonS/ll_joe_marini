using System;

namespace ProgChallenge
{
    class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected decimal _balance;

        public Account(string firstName, string lastName, decimal balance)
        {
            FirstName = firstName;
            LastName = lastName;
            _balance = balance;
        }

        public decimal Balance
        {
            get => _balance;
        }
        public string AccountOwner
        {
            get => $"{FirstName} {LastName}";
        }

        public void Deposit(decimal d)
        {
            _balance += d;
        }

        public virtual void Withdraw(decimal d)
        {
            _balance -= d;
        }

    }
}