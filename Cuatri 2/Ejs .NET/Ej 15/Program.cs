using Dominio;

class Program
{
    static void Main(string[] args)
    {
        List<Barco> flota = new List<Barco>();

        Acorzado acorazado = new Acorzado
        {
            Nombre = "Titan",
            Flotabilidad = 80,
            Solidez = 90,
            Estabilidad = 85,
            VelocidadCrucero = 30,
            Blindaje = 95,
            PotenciaFuego = 100
        };

        Destructor destructor = new Destructor
        {
            Nombre = "Mortal",
            Flotabilidad = 75,
            Solidez = 70,
            Estabilidad = 80,
            VelocidadCrucero = 40,
            PotenciaFuego = 85,
            Maniobrabilidad = 90
        };

        BarcoHospital barcoHospital = new BarcoHospital();

        LanchaMedica lanchaMedica1 = new LanchaMedica("La Gaucha");
        LanchaMedica lanchaMedica2 = new LanchaMedica("El Gaucho");

        flota.Add(acorazado);
        flota.Add(destructor);
        flota.Add(barcoHospital);
        flota.Add(lanchaMedica1);
        flota.Add(lanchaMedica2);

        Console.WriteLine("========================================");
        Console.WriteLine("        SISTEMA DE FLOTA NAVAL");
        foreach (Barco barco in flota)
        {
            Console.WriteLine("========================================\n");
            barco.MostrarInfo();
        }
        Console.WriteLine("========================================");
        Console.WriteLine("        FIN DEL REPORTE");
        Console.WriteLine("========================================");
    }
}