namespace Exceptions
{
    public class NombreInvalidoException : DatosInvalidosException
    {
        public NombreInvalidoException() : base("El nombre no puede ser nulo o vacío.")
        {
        }

        public NombreInvalidoException(string message) : base(message)
        {
        }
    }
}