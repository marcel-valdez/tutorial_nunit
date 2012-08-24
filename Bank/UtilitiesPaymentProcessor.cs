namespace Bank
{
    using System;
    using System.Collections.Generic;

    public class UtilitiesPaymentProcessor
    {
        private Account utilitiesAccount;
        private IDictionary<string, decimal> bills = new Dictionary<string, decimal>();

        public UtilitiesPaymentProcessor(Account utilitiesAccount)
        {
            this.utilitiesAccount = utilitiesAccount;
        }

        public void AddBill(string billCode, decimal debt)
        {
            this.bills.Add(billCode, debt);
        }

        public decimal PayBill(string billCode, Account payer, decimal payment)
        {
            payer.TransferFunds(utilitiesAccount, payment);
            this.bills[billCode] -= payment;

            return this.bills[billCode];
        }

        public decimal GetBalance(string billCode)
        {
            return this.bills[billCode];
        }
    }
}
