namespace Dominio
{
    public class BarcoHospital : Barco
    {
        public int CapacidadDePacientes { get; set; }

        public BarcoHospital()
        {
            Nombre = "Sibelancia";
            Flotabilidad = 100;
            Solidez = 80;
            Estabilidad = 100;
            VelocidadCrucero = 20;
            CapacidadDePacientes = 75;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Capacidad de pacientes: {CapacidadDePacientes} pacientes");
        }
    }
}