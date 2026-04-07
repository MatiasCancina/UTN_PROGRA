namespace Dominio
{
    public class Locomotora
    {
        public Locomotora(double peso, double velocidadMaxima, int arrastrePesoUtil)
        {
            this.Peso = peso;
            this.VelocidadMaxima = velocidadMaxima;
            this.ArrastrePesoUtil = arrastrePesoUtil;
        }

        private double _peso;
        public double Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        private double _velocidadMaxima;
        public double VelocidadMaxima
        {
            get { return _velocidadMaxima; }
            set { _velocidadMaxima = value; }
        }

        private int _arrastrePesoUtil;
        public int ArrastrePesoUtil
        {
            get => _arrastrePesoUtil;
            set => _arrastrePesoUtil = value;
        }
    }
}