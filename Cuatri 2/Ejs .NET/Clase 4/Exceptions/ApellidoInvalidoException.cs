namespace Exceptions
{
    public class ApellidoInvalidoException : DatosInvalidosException
    {
        public ApellidoInvalidoException() : base("El apellido no puede ser nulo o vacío.")
        {
        }

        public ApellidoInvalidoException(string message) : base(message)
        {
        }
    }
}