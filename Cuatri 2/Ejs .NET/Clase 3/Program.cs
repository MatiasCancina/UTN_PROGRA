Console.WriteLine("\n-------------------------Persona-------------------------\n");

Persona objPersona = new Persona();
objPersona.Nombre = "Juan";
objPersona.Apellido = "Pérez";
Console.WriteLine(objPersona.Presentarse());

Visitante objVisitante = new Visitante();
objVisitante.Nombre = "María";
objVisitante.Apellido = "Gómez";
objVisitante.DNI = 12345678;
Console.WriteLine(objVisitante.Presentarse());

Guardia objGuardia = new Guardia();
objGuardia.Nombre = "Carlos";
objGuardia.Apellido = "Cancina";
Console.WriteLine(objGuardia.Presentarse());
Console.WriteLine(objGuardia.ControlarDocumento(objVisitante));

Console.WriteLine("\n-------------------------Robot-------------------------\n");

Robot robotina = new Robot("Robotina2000", 100, new Oruga());
Console.WriteLine(robotina.MostrarInformacion());
robotina.Recorrer(10);
Console.WriteLine(robotina.MostrarInformacion());
robotina.Recorrer(15550);
Console.WriteLine(robotina.MostrarInformacion());
