using System;

namespace ProgChallenge
{
    class BankAccount
    {
        private string _firstName;
        private string _lastName;

        public decimal Balance { get; set; }
        public BankAccount(string firstName, string lastName, decimal balance)
        {
            _firstName = firstName;
            _lastName = lastName;
            Balance = balance;
        }

        public string AccountOwner
        {
            get => $"{_firstName} {_lastName}";
        }

        public virtual void Deposit(decimal d)
        {
            Balance += d;
        }

        public virtual void Withdraw(decimal d)
        {
            Balance -= d;
        }

    }
}