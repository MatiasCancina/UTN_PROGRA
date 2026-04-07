namespace Dominio
{
    public class VagonPasajeros : Vagon
    {
        public int CantidadDePasajeros()
        {
            if (this.AnchoUtil <= 2.5)
                return 8 * this.Largo;
            else return 10 * this.Largo;
        }

        public override int PesoMaximo()
        {
            return this.CantidadDePasajeros() * 80;
        }
    }
}