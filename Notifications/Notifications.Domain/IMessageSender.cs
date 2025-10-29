namespace Notifications.Domain
{
    /// <summary>
    /// Interfaz que define el contrato para los diferentes métodos de envío de mensajes.
    /// Implementa el patrón Strategy permitiendo intercambiar algoritmos de envío.
    /// </summary>
    public interface IMessageSender
    {
        /// <summary>
        /// Envía un mensaje utilizando el método específico implementado por la clase concreta.
        /// </summary>
        /// <param name="Message">El contenido del mensaje a enviar.</param>
        /// <returns>Una cadena de confirmación que indica el resultado del envío.</returns>
        string SendMessage(string Message);
    }
}