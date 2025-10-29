namespace Notifications.Domain
{
    /// <summary>
    /// Estrategia concreta para el envío de mensajes por correo electrónico.
    /// Implementa la interfaz IMessageSender para proporcionar funcionalidad específica de email.
    /// </summary>
    public class EmailMessageSender : IMessageSender
    {
        /// <summary>
        /// Envía un mensaje utilizando el servicio de correo electrónico.
        /// </summary>
        /// <param name="Message">El contenido del mensaje a enviar por email.</param>
        /// <returns>Una cadena de confirmación que indica que el mensaje fue enviado por email.</returns>
        public string SendMessage(string Message)
        {
            return "'" + Message + "'   : This Message has been sent using Email";
        }
    }
}