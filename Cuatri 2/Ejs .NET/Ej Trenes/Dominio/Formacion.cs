namespace Dominio
{
    public class Formacion
    {
        List<Locomotora> _locomotoras;
        public List<Locomotora> Locomotoras
        {
            get { return _locomotoras; }
            set { _locomotoras = value; }
        }

        List<Vagon> _vagones;
        public List<Vagon> Vagones
        {
            get { return _vagones; }
            set { _vagones = value; }
        }

        private bool _estaEnMovimiento;
        public bool EstaEnMovimiento
        {
            get { return _estaEnMovimiento; }
            set { _estaEnMovimiento = value; }
        }

    }
}