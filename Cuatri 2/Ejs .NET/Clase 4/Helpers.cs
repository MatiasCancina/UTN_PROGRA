using Dominio;

namespace Helpers
{
    public static class Printer
    {
        public static void Print(Persona p)
        {
            Console.WriteLine(p.Saludar());
        }
    }
}