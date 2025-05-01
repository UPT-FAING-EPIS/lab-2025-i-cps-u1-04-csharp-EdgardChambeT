namespace ATM.Domain
{
    /// <summary>
    /// Comando concreto para retirar fondos de una cuenta.
    /// </summary>
    public class WithdrawCommand : ICommand
    {
        private readonly Account _account;
        private readonly decimal _amount;

        /// <summary>
        /// Inicializa una nueva instancia del comando de retiro.
        /// </summary>
        /// <param name="account">Cuenta objetivo.</param>
        /// <param name="amount">Monto a retirar.</param>
        public WithdrawCommand(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
        }

        /// <inheritdoc/>
        public void Execute()
        {
            _account.Withdraw(_amount);
        }
    }
}