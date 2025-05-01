using NUnit.Framework;

namespace ATM.Domain.Tests
{
    /// <summary>
    /// Pruebas unitarias para las clases <see cref="ATM"/>, <see cref="WithdrawCommand"/> y <see cref="DepositCommand"/>.
    /// </summary>
    public class ATMTests
    {
        /// <summary>
        /// Verifica que el comando de retiro actualice correctamente el balance.
        /// </summary>
        [Test]
        public void GivenAccountAndWithdraw_ThenExecute_ReturnsCorrectAmount()
        {
            var account = new Account() { AccountBalance = 300 };
            decimal amount = 100;
            var withdraw = new WithdrawCommand(account, amount);
            new ATM(withdraw).Action();
            Assert.That(account.AccountBalance, Is.EqualTo(200));
        }

        /// <summary>
        /// Verifica que el comando de depósito actualice correctamente el balance.
        /// </summary>
        [Test]
        public void GivenAccountAndDeposit_ThenExecute_ReturnsCorrectAmount()
        {
            var account = new Account() { AccountBalance = 200 };
            decimal amount = 100;
            var deposit = new DepositCommand(account, amount);
            new ATM(deposit).Action();
            Assert.That(account.AccountBalance, Is.EqualTo(300));
        }
    }
}