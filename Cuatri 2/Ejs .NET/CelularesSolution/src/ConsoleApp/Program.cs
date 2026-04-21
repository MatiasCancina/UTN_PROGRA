using Clases;

Usuario Catalina = new Usuario("Catalina", new Iphone());
Usuario Juliana = new Usuario("Juliana", new Motorola());

Console.WriteLine(Catalina.Nombre);
Console.WriteLine(Juliana.Nombre);

Console.WriteLine("Batería de Catalina: " + Catalina.TotalBateria());
Console.WriteLine("Batería de Juliana: " + Juliana.TotalBateria());

Catalina.Celular.Llamar(Juliana.Celular, 100);
Console.WriteLine("Hacemos una llamada de Catalina a Juliana de 100 segundos");
Console.WriteLine("Batería de Catalina: " + Catalina.TotalBateria());
Console.WriteLine("Batería de Juliana: " + Juliana.TotalBateria());

Juliana.Celular.Recargar();
Console.WriteLine("Celular de Juliana se recarga...");
Console.WriteLine("Batería de Catalina: " + Catalina.TotalBateria());
Console.WriteLine("Batería de Juliana: " + Juliana.TotalBateria());


Juliana.Celular.Llamar(Catalina.Celular, 200);
Console.WriteLine("Hacemos una llamada de Juliana a Catalina de 200 segundos");
Console.WriteLine("Batería de Juliana: " + Juliana.TotalBateria());
Console.WriteLine("Batería de Catalina: " + Catalina.TotalBateria());