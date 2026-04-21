namespace Clases
{
    public abstract class Celular
    {
        public Celular()
        {
            this.Bateria = new Bateria();
        }

        public void Recargar()
        {
            this.Bateria.Recargar();
        }

        public abstract void PerdidaDeBateria(int duracion);
        public double PuntosDeBateria()
        {
            return _bateria.PuntosDeBateria;
        }

        public void Llamar(Celular destino, int duracion)
        {
            this.PerdidaDeBateria(duracion);
            destino.PerdidaDeBateria(duracion);
        }

        private Bateria _bateria;
        public Bateria Bateria
        {
            get { return _bateria; }
            set { _bateria = value; }
        }

        public bool EstaApagado()
        {
            if (_bateria.PuntosDeBateria == 0)
            {
                return true;
            }
            return false;
        }
    }
}