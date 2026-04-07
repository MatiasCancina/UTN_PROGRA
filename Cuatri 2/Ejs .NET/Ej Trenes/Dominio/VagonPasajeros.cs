namespace Dominio
{
    public class VagonPasajeros : Vagon
    {
        public VagonPasajeros(double ancho, double largo, double anchoUtil)
        {
            this.Ancho = ancho;
            this.Largo = largo;
            this.AnchoUtil = anchoUtil;
        }

        public int CantidadDePasajeros()
        {
            if (this.AnchoUtil <= 2.5)
                return (int)(8 * this.Largo);
            else return (int)(10 * this.Largo);
        }

        public override double PesoMaximo()
        {
            double pesoMaximo = this.CantidadDePasajeros() * 80;
            return pesoMaximo;
        }
    }
}