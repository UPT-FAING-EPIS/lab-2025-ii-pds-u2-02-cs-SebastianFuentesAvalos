namespace Notifications.Domain
{
    /// <summary>
    /// Estrategia concreta para el envío de mensajes por SMS.
    /// Implementa la interfaz IMessageSender para proporcionar funcionalidad específica de mensajería de texto.
    /// </summary>
    public class SmsMessageSender : IMessageSender
    {
        /// <summary>
        /// Envía un mensaje utilizando el servicio de SMS.
        /// </summary>
        /// <param name="Message">El contenido del mensaje a enviar por SMS.</param>
        /// <returns>Una cadena de confirmación que indica que el mensaje fue enviado por SMS.</returns>
        public string SendMessage(string Message)
        {
            return "'" + Message + "' : This Message has been sent using SMS";
        }
    }
}