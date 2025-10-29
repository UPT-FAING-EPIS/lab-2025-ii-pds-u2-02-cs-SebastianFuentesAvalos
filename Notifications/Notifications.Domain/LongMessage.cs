namespace Notifications.Domain
{
    /// <summary>
    /// Implementación concreta para mensajes largos que pueden enviarse por cualquier medio.
    /// Esta clase no impone restricciones de longitud en el contenido del mensaje.
    /// </summary>
    public class LongMessage: AbstractMessage
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase LongMessage con el enviador especificado.
        /// </summary>
        /// <param name="messageSender">La estrategia de envío a utilizar para mensajes largos.</param>
        public LongMessage(IMessageSender messageSender)
        {
            this._messageSender = messageSender;
        }
        
        /// <summary>
        /// Envía un mensaje largo utilizando la estrategia de envío configurada.
        /// </summary>
        /// <param name="Message">El contenido del mensaje a enviar (sin restricciones de longitud).</param>
        /// <returns>Una cadena de confirmación del envío del mensaje.</returns>
        public override string SendMessage(string Message)
        {
           return _messageSender!.SendMessage(Message);
        }
    }
}