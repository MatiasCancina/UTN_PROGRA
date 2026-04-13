using Exceptions;

namespace Dominio
{
    public abstract class Persona
    {
        private string nombre;

        private string apellido;
        private string email;

        public string GetNombre()
        {
            if (string.IsNullOrEmpty(this.nombre))
            {
                throw new NombreInvalidoException();
            }

            return this.nombre;
        }

        public string GetApellido()
        {
            if (string.IsNullOrEmpty(this.apellido))
            {
                throw new ApellidoInvalidoException();
            }

            return this.apellido;

        }

        public string GetEmail()
        {
            return this.email;
        }

        public Persona()
        {
            // this.nombre = "Sin nombre";
            // this.apellido = "Sin apellido";
            // this.email = "Sin email";
        }

        public Persona(string nombre, string apellido, string email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetApellido(string apellido)
        {
            if (apellido != this.nombre)
            {
                this.apellido = apellido;

            }
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public virtual string Saludar()
        {
            return $"Hola, mi nombre es {this.GetNombre()} {this.GetApellido()}, mi email es {this.GetEmail()}";
        }
    }
}
