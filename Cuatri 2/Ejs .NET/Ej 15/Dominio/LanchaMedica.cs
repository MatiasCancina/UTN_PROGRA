namespace Dominio
{
    public class LanchaMedica : Barco
    {
        public bool MotorFueraDeBorda { get; set; }
        public double CapacidadGrua { get; set; }
        public double Maniobrabilidad { get; set; }

        public LanchaMedica(string nombre)
        {
            Nombre = nombre;
            Flotabilidad = 90;
            Solidez = 60;
            Estabilidad = 50;
            VelocidadCrucero = 60;
            MotorFueraDeBorda = true;
            CapacidadGrua = 300; // kg
            Maniobrabilidad = 55; // porcentaje
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Motor fuera de borda: {(MotorFueraDeBorda ? "Sí" : "No")}");
            Console.WriteLine($"Capacidad de grúa: {CapacidadGrua} kg");
            Console.WriteLine($"Maniobrabilidad: {Maniobrabilidad}");
        }
    }
}