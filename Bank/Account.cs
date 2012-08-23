namespace Bank
{
    using System;

    public class Account
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public void TransferFunds(Account destination, decimal amount)
        {
            if(this.balance < amount)
            {
                throw new InsufficientFundsException("A ${0:0.00} transfer was requested, but the source account did not have enough balance.");
            }

            this.balance -= amount;
            destination.balance += amount;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
        }
    }
}
