namespace Exceptions
{
    public class DatosInvalidosException : Exception
    {
        public DatosInvalidosException() : base("Error en el ingreso de datos")
        {
        }

        public DatosInvalidosException(string message) : base(message)
        {
        }
    }
}