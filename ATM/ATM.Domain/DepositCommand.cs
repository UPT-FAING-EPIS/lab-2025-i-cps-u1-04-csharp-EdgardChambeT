namespace ATM.Domain
{
    /// <summary>
    /// Comando concreto para depositar fondos en una cuenta.
    /// </summary>
    public class DepositCommand : ICommand
    {
        private readonly Account _account;
        private readonly decimal _amount;

        /// <summary>
        /// Inicializa una nueva instancia del comando de depósito.
        /// </summary>
        /// <param name="account">Cuenta objetivo.</param>
        /// <param name="amount">Monto a depositar.</param>
        public DepositCommand(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
        }

        /// <inheritdoc/>
        public void Execute()
        {
            _account.Deposit(_amount);
        }        
    }
}