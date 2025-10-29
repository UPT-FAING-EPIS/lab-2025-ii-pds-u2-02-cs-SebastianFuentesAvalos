namespace CustomerApp.Domain
{
    /// <summary>
    /// Representa un cliente en el sistema con información personal y de contacto.
    /// Implementa el patrón de construcción estática para crear instancias válidas.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Obtiene o establece el nombre del cliente.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        
        /// <summary>
        /// Obtiene o establece la dirección de correo electrónico del cliente.
        /// </summary>
        public string Email { get; set; } = string.Empty;
        
        /// <summary>
        /// Obtiene o establece el número de teléfono móvil del cliente.
        /// </summary>
        public string MobileNumber { get; set; } = string.Empty;
        
        /// <summary>
        /// Obtiene o establece la dirección física del cliente.
        /// </summary>
        public string Address { get; set; } = string.Empty;
        
        /// <summary>
        /// Obtiene o establece la contraseña del cliente.
        /// </summary>
        public string Password { get; set; } = string.Empty;
        
        /// <summary>
        /// Crea una nueva instancia de Customer con los datos proporcionados.
        /// </summary>
        /// <param name="name">Nombre del cliente.</param>
        /// <param name="email">Correo electrónico del cliente.</param>
        /// <param name="mobileNumber">Número de teléfono móvil.</param>
        /// <param name="address">Dirección física del cliente.</param>
        /// <param name="password">Contraseña del cliente.</param>
        /// <returns>Una nueva instancia de Customer con los datos especificados.</returns>
        public static Customer Create(string name, string email, string mobileNumber, string address, string password)
        {
            return new Customer() {
                Name = name, Email = email, MobileNumber = mobileNumber, Address = address, Password = password
            };
        }
    }
}