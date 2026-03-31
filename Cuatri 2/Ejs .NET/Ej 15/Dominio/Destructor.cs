namespace Dominio
{
    public class Destructor : Barco
    {
        public double PotenciaFuego { get; set; }
        public double Maniobrabilidad { get; set; }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Potencia de fuego: {PotenciaFuego}");
            Console.WriteLine($"Maniobrabilidad: {Maniobrabilidad}");
        }
    }
}