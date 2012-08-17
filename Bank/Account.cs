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
            throw new NotImplementedException();
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
