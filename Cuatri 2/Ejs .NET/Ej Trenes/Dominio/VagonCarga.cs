namespace Dominio
{
    public class VagonCarga : Vagon
    {
        private int _cargaMaxima;
        public int CargaMaxima
        {
            get { return _cargaMaxima; }
            set { _cargaMaxima = value; }
        }

        public override int PesoMaximo()
        {
            return (this.CargaMaxima + 160);
        }
    }
}