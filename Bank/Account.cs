namespace Bank
{
    using System;

    public class Account
    {

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public virtual void TransferFunds(Account destination, decimal amount)
        {
            if(this.Balance < amount)
            {
                throw new InsufficientFundsException("A ${0:0.00} transfer was requested, but the source account did not have enough balance.");
            }

            this.Balance -= amount;
            destination.Balance += amount;
        }

        public virtual decimal Balance
        {
            get;
            private set;
        }
    }
}
