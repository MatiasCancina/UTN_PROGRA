namespace Dominio
{
    public class Deposito
    {
        private List<Formacion> _formaciones;
        public List<Formacion> Formaciones
        {
            get { return _formaciones; }
            set { _formaciones = value; }
        }

        private List<Locomotora> _locomotoras;
        public List<Locomotora> Locomotoras
        {
            get { return _locomotoras; }
            set { _locomotoras = value; }
        }

        public void AgregarLocomotoraEnFormacion(Formacion formacion, Locomotora locomotora)
        {
            if (!formacion.EstaEnMovimiento)
            {
                formacion.Locomotoras.Add(locomotora);
            }
        }
    }
}