using System;

namespace ATM.Domain
{
    /// <summary>
    /// Representa una cuenta bancaria con operaciones básicas de retiro y depósito.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Máximo monto permitido para depósito ($10,000 USD).
        /// </summary>
        public const decimal MAX_INPUT_AMOUNT = 10000;

        /// <summary>
        /// Número único de identificación de la cuenta.
        /// </summary>
        public int AccountNumber { get; set; }

        /// <summary>
        /// Balance actual disponible en la cuenta.
        /// </summary>
        public decimal AccountBalance { get; set; }

        /// <summary>
        /// Retira un monto específico de la cuenta.
        /// </summary>
        /// <param name="amount">Monto a retirar (debe ser positivo y menor o igual al balance).</param>
        /// <exception cref="ArgumentException">Se lanza si el monto es inválido o excede el balance.</exception>
        public void Withdraw(decimal amount)
        {
            if (amount > AccountBalance) 
                throw new ArgumentException("The input amount is greater than balance.");
            AccountBalance -= amount;            
        }

        /// <summary>
        /// Deposita un monto específico en la cuenta.
        /// </summary>
        /// <param name="amount">Monto a depositar (debe ser positivo y no exceder el límite máximo).</param>
        /// <exception cref="ArgumentException">Se lanza si el monto es inválido o excede el límite.</exception>
        public void Deposit(decimal amount)
        {
            if (amount > MAX_INPUT_AMOUNT) 
                throw new ArgumentException("The input amount is greater than maximum allowed.");
            AccountBalance += amount;            
        }
    }
}