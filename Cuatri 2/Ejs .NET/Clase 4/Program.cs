using Dominio;
using Helpers;
using Exceptions;

Persona unaPersona = new Alumno("Leo", "Perez", "leoperez@example.com", "1234", 8.5f);
Alumno unAlumno = (Alumno)unaPersona;

unaPersona = new Docente("Matematica", 20);
// unaPersona = null;

// unaPersona.SetNombre("Juan");
// unaPersona.SetApellido("Perez");
// unaPersona.SetEmail("juanperez@example.com");

try
{
    Helpers.Printer.Print(unAlumno);
    Helpers.Printer.Print(unaPersona);
}
catch (NombreInvalidoException nre)
{
    Console.WriteLine("revise el nombre. Detalles: " + nre.Message);
}
catch (ApellidoInvalidoException are)
{
    Console.WriteLine("revise el apellido. Detalles: " + are.Message);  
}
catch (Exception ex)
{
    Console.WriteLine("Error al imprimir la persona: " + ex.Message);
}
finally
{
    Console.WriteLine("Se ejecuta haya error o no.");
}

Console.WriteLine("Terminado!");