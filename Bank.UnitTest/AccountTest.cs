namespace Bank.UnitTest
{
    using System;
    using NUnit.Framework;

    [TestFixture] // El atributo TestFixture identifica a esta clase como una clase de pruebas
    public class AccountTest
    {
        [Test] // El atributo Test identifica a este método como una prueba unitaria
        public void TransferFunds()
        {
            Account source = new Account();
            source.Deposit(200m);
            Account destination = new Account();
            destination.Deposit(150m);

            source.TransferFunds(destination, 100m);

            // Las aserciones se realizan por medio de la clase estática Assert
            // En este caso se trata de una aserción de igualdad por medio del método
            // estático AreEqual([valor esperado], [valor obtenido])
            Assert.AreEqual(250m, destination.Balance);
            Assert.AreEqual(100m, source.Balance);
        }
    }
}
