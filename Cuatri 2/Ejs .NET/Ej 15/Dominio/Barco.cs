namespace Dominio
{
    public abstract class Barco
    {
        public string Nombre { get; set; }
        public double Flotabilidad { get; set; }
        public double Solidez { get; set; }
        public double Estabilidad { get; set; }
        public double VelocidadCrucero { get; set; }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Tipo: {GetType().Name}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Flotabilidad: {Flotabilidad}");
            Console.WriteLine($"Solidez: {Solidez}");
            Console.WriteLine($"Estabilidad: {Estabilidad}");
            Console.WriteLine($"Velocidad de crucero: {VelocidadCrucero}");
        }
    }
}