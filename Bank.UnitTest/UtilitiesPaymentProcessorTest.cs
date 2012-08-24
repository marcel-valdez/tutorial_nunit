namespace Bank.UnitTest
{
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.Reflection;
    using NSubstitute;

    [TestFixture]
    public class UtilitiesPaymentProcessorTest
    {
        [Test]
        public void TestIfItCanAddBill()
        {
            // Se inicializan los objetos a utilizar
            var utilitesAccount = new Account();
            var target = new UtilitiesPaymentProcessor(utilitesAccount);
            string billCode = "bill";
            int debt = 1;

            // Se ejercita el código bajo prueba
            target.AddBill(billCode, debt);

            // Se obtienen las facturas del objeto
            IDictionary<string, decimal> bills = GetBills(target);

            // Se verifica que efectivamente se haya agregado la factura
            Assert.That(bills.Keys, Contains.Item(billCode));
            Assert.That(bills[billCode], Is.EqualTo(debt));
        }

        [Test]
        public void TestIfItCanPayBill()
        {
            // Se inicializan los mocks
            var utilitesAccount = Substitute.For<Account>();
            var payerAccount = Substitute.For<Account>();
            payerAccount.Balance.Returns(20);
            utilitesAccount.Balance.Returns(0);

            // Se inicializa el objeto a probar
            var target = new UtilitiesPaymentProcessor(utilitesAccount);
            string billCode = "bill";
            decimal debt = 10;
            decimal leftOver = 1;
            IDictionary<string, decimal> bills = GetBills(target);
            bills.Add(billCode, debt);

            // Se ejercita el código bajo prueba
            decimal actualLeftOver = target.PayBill(billCode, payerAccount, debt - leftOver);

            // Verificar que el método haya funcionado correctamente
            // Prueba de Caja negra
            Assert.That(bills[billCode], Is.EqualTo(actualLeftOver));
            // Prueba de Caja blanca o transparente
            // Se especifica que se debe transferir fondos del deudor al acreedor.
            payerAccount.Received().TransferFunds(utilitesAccount, debt - leftOver);
            utilitesAccount.DidNotReceive().TransferFunds(Arg.Any<Account>(), Arg.Any<decimal>());
        }

        [Test]
        public void TestIfItCanGetTheBalance()
        {
            // Arrange
            var target = new UtilitiesPaymentProcessor(null);
            string billCode = "bill";
            decimal expectedBalance = 10;

            // Act
            target.AddBill(billCode, expectedBalance);
            decimal actualBalance = target.GetBalance(billCode);

            // Assert
            Assert.That(actualBalance, Is.EqualTo(expectedBalance));
        }

        private static IDictionary<string, decimal> GetBills(UtilitiesPaymentProcessor target)
        {
            var fieldInfo = typeof(UtilitiesPaymentProcessor)
                                .GetField("bills", BindingFlags.NonPublic | BindingFlags.Instance);

            var bills = (IDictionary<string, decimal>)fieldInfo.GetValue(target);

            return bills;
        }
    }
}
