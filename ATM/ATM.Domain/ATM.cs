namespace ATM.Domain
{
    /// <summary>
    /// Clase que actúa como invocador (Invoker) en el patrón Command.
    /// </summary>
    public class ATM
    {
        private readonly ICommand _command;

        /// <summary>
        /// Inicializa una nueva instancia del ATM con un comando específico.
        /// </summary>
        /// <param name="command">Comando a ejecutar (ej: retiro o depósito).</param>
        public ATM(ICommand command)
        {
            _command = command;
        }

        /// <summary>
        /// Ejecuta el comando configurado.
        /// </summary>
        public void Action()
        {
            _command.Execute();
        }
    }
}