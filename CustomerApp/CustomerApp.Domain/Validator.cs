namespace CustomerApp.Domain
{
    /// <summary>
    /// Clase responsable de validar objetos Customer según las reglas de negocio.
    /// Implementa el Principio de Responsabilidad Única (SRP) al encapsular toda la lógica de validación.
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// Valida que un objeto Customer cumpla con todas las reglas de negocio requeridas.
        /// </summary>
        /// <param name="customer">El objeto Customer a validar.</param>
        /// <returns>True si la validación es exitosa.</returns>
        /// <exception cref="ArgumentException">Se lanza cuando algún campo requerido está vacío o es nulo.</exception>
        public bool ValidateCustomer(Customer customer)
        {
            //Need to Validate the Customer Object
            if (string.IsNullOrEmpty(customer.Name)) throw new ArgumentException("Name can't be null or empty");
            if (string.IsNullOrEmpty(customer.Email)) throw new ArgumentException("Email can't be null or empty");
            if (string.IsNullOrEmpty(customer.MobileNumber)) throw new ArgumentException("MobileNumber can't be null or empty");
            if (string.IsNullOrEmpty(customer.Address)) throw new ArgumentException("Address can't be null or empty");
            return true;
        }
    }
}