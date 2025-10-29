namespace Notifications.Domain
{
    /// <summary>
    /// Clase base abstracta para implementar el patrón Strategy en el sistema de mensajería.
    /// Define la estructura común para diferentes tipos de mensajes.
    /// </summary>
    public abstract class AbstractMessage
    {
        /// <summary>
        /// Instancia del enviador de mensajes que implementa la estrategia específica de envío.
        /// </summary>
        protected IMessageSender? _messageSender;
        
        /// <summary>
        /// Envía un mensaje utilizando la estrategia de envío configurada.
        /// </summary>
        /// <param name="Message">El contenido del mensaje a enviar.</param>
        /// <returns>Una cadena de confirmación del envío del mensaje.</returns>
        public abstract string SendMessage(string Message);        
    }
}