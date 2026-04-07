namespace Dominio
{
    abstract class Vagon
    {
        private double _ancho;
        public double Ancho
        {
            get { return _ancho; }
            set { _ancho = value; }
        }

        private double _largo;
        public double Largo
        {
            get { return _largo; }
            set { _largo = value; }
        }

        private double _anchoUtil;
        public double AnchoUtil
        {
            get { return _anchoUtil; }
            set { _anchoUtil = value; }
        }


        public abstract double PesoMaximo()
        {
            return this.CargaMaxima + 160;
        }
    }
}