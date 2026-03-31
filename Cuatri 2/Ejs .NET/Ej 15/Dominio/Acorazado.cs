namespace Dominio
{
    public class Acorzado : Barco
    {
        public double Blindaje { get; set; }
        public double PotenciaFuego { get; set; }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Blindaje: {Blindaje}");
            Console.WriteLine($"Potencia de fuego: {PotenciaFuego}");
        }
    }
}