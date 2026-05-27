using  ConsoleLibrary;


/*Implementación de Singleton */
Presidente.Eleccion("Leonardo", "Pinkas");
Presidente objPresidente = Presidente.DevolverInstancia();
Console.WriteLine($"El presidente es {objPresidente.Nombre} {objPresidente.Apellido}");



Presidente.Eleccion("Ned", "Flanders");
objPresidente = Presidente.DevolverInstancia();
Console.WriteLine($"El presidente es {objPresidente.Nombre} {objPresidente.Apellido}");


/*FIN Implementación de Singleton */


/* Ejemplo de uso de Abstract Factory */    

FabricaAbstracta fabrica;
Silla silla;
Mesa mesa;


fabrica = new FabricaEscandinava();

silla = fabrica.CrearSilla();
mesa = fabrica.CrearMesa();

Console.WriteLine("Imprimo los datos de la silla y la mesa creadas por la fabrica");
Console.WriteLine(silla.Estilo);
Console.WriteLine(mesa.Estilo);


/* Ejemplo de uso de Composite */   
Console.WriteLine("Ejemplo de composite");

Carpeta carpetaPrincipal = new Carpeta("Disco C", 7);

AnalizadorDeElementos(carpetaPrincipal);



Archivo unArchivoPesado = new Archivo("El retorno del Rey.mp4", 2048);

AnalizadorDeElementos(unArchivoPesado);
Archivo unArchivoLiviano = new Archivo("miscontraseñas.txt", 10);
AnalizadorDeElementos(unArchivoLiviano);


carpetaPrincipal.Agregar(unArchivoPesado);
carpetaPrincipal.Agregar(unArchivoLiviano);

Carpeta otraCarpeta = new Carpeta("Documentos", 10);
Archivo miCV = new Archivo("Mi curriculum vitae.docx", 500);
otraCarpeta.Agregar(miCV);
AnalizadorDeElementos(miCV);


Console.WriteLine("Imprimo el contenido de la carpeta principal sin la otra carpeta (carpeta Documentos)");

AnalizadorDeElementos(carpetaPrincipal);
AnalizadorDeElementos(otraCarpeta);

carpetaPrincipal.Agregar(otraCarpeta);
Console.WriteLine("Imprimo el contenido de la Carpeta Principal (DISCO C) con la otra carpeta (carpeta Documentos)");
AnalizadorDeElementos(carpetaPrincipal);


void AnalizadorDeElementos(Elemento unElemento)
{
    Console.WriteLine($"El elemento {unElemento.Nombre} pesa {unElemento.DevolverTamaño()} MB");
}