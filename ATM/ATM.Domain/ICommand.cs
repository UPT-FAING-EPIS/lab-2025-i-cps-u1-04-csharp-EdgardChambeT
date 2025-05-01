namespace ATM.Domain
{
    /// <summary>
    /// Interfaz base para los comandos del ATM. Define el método <see cref="Execute"/>.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Ejecuta la acción asociada al comando.
        /// </summary>
        void Execute();
    }
}