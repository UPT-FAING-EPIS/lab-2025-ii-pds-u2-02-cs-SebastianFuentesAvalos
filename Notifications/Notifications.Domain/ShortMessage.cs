namespace Notifications.Domain
{
    /// <summary>
    /// Implementación concreta para mensajes cortos con restricción de longitud máxima.
    /// Valida que el mensaje no exceda los 25 caracteres antes del envío.
    /// </summary>
    public class ShortMessage: AbstractMessage
    {
        /// <summary>
        /// Mensaje de error que se lanza cuando el mensaje excede la longitud permitida.
        /// </summary>
        public const string LARGE_ERROR_MESSAGE = "Unable to send the message as length > 25 characters";
        
        /// <summary>
        /// Inicializa una nueva instancia de la clase ShortMessage con el enviador especificado.
        /// </summary>
        /// <param name="messageSender">La estrategia de envío a utilizar para mensajes cortos.</param>
        public ShortMessage(IMessageSender messageSender)
        {
            this._messageSender = messageSender;
        }
        
        /// <summary>
        /// Envía un mensaje corto validando primero su longitud.
        /// </summary>
        /// <param name="Message">El contenido del mensaje a enviar (máximo 25 caracteres).</param>
        /// <returns>Una cadena de confirmación del envío del mensaje.</returns>
        /// <exception cref="ArgumentException">Se lanza cuando el mensaje excede los 25 caracteres.</exception>
        public override string SendMessage(string Message)
        {
            if (Message.Length <= 25)
                return _messageSender!.SendMessage(Message);
            else
                throw new ArgumentException(LARGE_ERROR_MESSAGE);
        }
    }
}