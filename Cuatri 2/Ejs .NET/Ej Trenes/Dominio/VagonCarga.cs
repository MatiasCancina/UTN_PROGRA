namespace Dominio
{
    public class VagonCarga : Vagon
    {
        private double _cargaMaxima;
        public double CargaMaxima
        {
            get { return _cargaMaxima; }
            set { _cargaMaxima = value; }
        }

        public VagonCarga(double ancho, double largo, double anchoUtil, double cargaMaxima)
        {
            this.Ancho = ancho;
            this.Largo = largo;
            this.AnchoUtil = anchoUtil;
            this.CargaMaxima = cargaMaxima;
        }

        public override double PesoMaximo()
        {
            return (this.CargaMaxima + 160);
        }
    }
}