namespace Bank.IntegrationTest
{
    using NUnit.Framework;

    [TestFixture]
    public class UtilitiesPayment_Account_Test
    {
        [Test]
        public void TestAnAccountCanPayABillThroughPaymentProcessor()
        {
            // Arrange
            string billCode = "bill";
            int initialPayerBalance = 100;
            int initialDebt = 50;
            int payment = 40;
            int expectedDebtBalance = initialDebt - payment;
            int expectedPayerBalance = initialPayerBalance - payment;

            var utilitiesAccount = new Account();
            var payerAccount = new Account();
            payerAccount.Deposit(initialPayerBalance);
            var processor = new UtilitiesPaymentProcessor(utilitiesAccount);


            // Act
            processor.AddBill(billCode, initialDebt);
            decimal debtBalance = processor.PayBill(billCode, payerAccount, payment);

            // Assert
            Assert.That(debtBalance, Is.EqualTo(expectedDebtBalance));
            Assert.That(utilitiesAccount.Balance, Is.EqualTo(payment));
            Assert.That(payerAccount.Balance, Is.EqualTo(expectedPayerBalance));
        }
    }
}
