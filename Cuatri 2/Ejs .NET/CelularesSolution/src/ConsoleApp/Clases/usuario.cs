namespace Clases
{
    public class Usuario : Persona
    {
        private Celular _celular;
        public Celular Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }

        public double TotalBateria()
        {
            return this.Celular.PuntosDeBateria();
        }

        public Usuario(string nombre, Celular celular)
        {
            this.Nombre = nombre;
            this.Celular = celular;
        }
    }
}