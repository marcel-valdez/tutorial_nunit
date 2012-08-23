namespace Bank
{
    using System;

    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message)
            : base(message)
        {            
        }
    }
}
