using Dominio;

Formacion formacion1 = new Formacion();
formacion1.EstaEnMovimiento = false;
formacion1.Locomotoras = new List<Locomotora>();
formacion1.Vagones = new List<Vagon>();

Locomotora locomotora1 = new Locomotora(10, 100, 1000);
Locomotora locomotora2 = new Locomotora(15, 120, 1500);

Deposito deposito = new Deposito();
deposito.AgregarLocomotoraEnFormacion(formacion1, locomotora1);
formacion1.EstaEnMovimiento = true;
deposito.AgregarLocomotoraEnFormacion(formacion1, locomotora2);

Console.WriteLine("Locomotoras en formacion: " + formacion1.Locomotoras.Count);
Console.WriteLine("Vagones en formacion: " + formacion1.Vagones.Count);
Console.WriteLine("Formacion en movimiento: " + formacion1.EstaEnMovimiento);
Console.WriteLine("Locomotora 1 - Peso: " + locomotora1.Peso + ", Velocidad Maxima: " + locomotora1.VelocidadMaxima + ", Arrastre Peso Util: " + locomotora1.ArrastrePesoUtil);
Console.WriteLine("Locomotora 2 - Peso: " + locomotora2.Peso + ", Velocidad Maxima: " + locomotora2.VelocidadMaxima + ", Arrastre Peso Util: " + locomotora2.ArrastrePesoUtil);