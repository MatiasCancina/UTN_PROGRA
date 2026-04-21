namespace Clases
{
    public class Bateria
    {
        public readonly double PuntoMaximoDeCarga = 5;
        private double _puntosDeBateria;
        public double PuntosDeBateria
        {
            get { return _puntosDeBateria; }
            set { _puntosDeBateria = value; }
        }

        public Bateria()
        {
            this.Recargar();
        }

        public void Recargar()
        {
            PuntosDeBateria = PuntoMaximoDeCarga;
        }
    }
}