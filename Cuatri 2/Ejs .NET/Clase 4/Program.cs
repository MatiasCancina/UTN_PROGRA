using Dominio;
using Helpers;

Persona unaPersona = new Alumno("Leo", "Perez", "leoperez@example.com", "1234", 8.5f);
Alumno unAlumno = (Alumno)unaPersona;

unaPersona = new Docente("Matematica", 20);

unaPersona.SetNombre("Juan");
unaPersona.SetApellido("Perez");
unaPersona.SetEmail("juanperez@example.com");

unAlumno.SetNombre("Juan");
unAlumno.SetApellido("Perez");
unAlumno.SetEmail("juanperez@example.com");

Helpers.Printer.Print(unaPersona);
Helpers.Printer.Print(unAlumno);
