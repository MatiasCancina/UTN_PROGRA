// Conjunto de números únicos
HashSet<Empleado> unicos = new HashSet<Empleado>();

// Agregar elementos

Gerente objGerente = new Gerente();
objGerente.Legajo = 1234;
unicos.Add(objGerente);
Gerente nuevoGerente = new Gerente();
nuevoGerente.Legajo = 1234;
unicos.Add(nuevoGerente); // Ignorado, ya existe
unicos.Add(new Administrativo()); // Ignorado, ya existe

// Saber si existe un elemento
Console.WriteLine(unicos.Contains(objGerente)); // Eliminar un elemento
unicos.Remove(objGerente); // Recorrer el conjunto
foreach (Empleado unico in unicos)
{
    Console.WriteLine(unico.CalcularSueldo());
}

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// BonoPresentismo bonoA = new BonoPresentismoA();
// BonoPresentismo bonoB = new BonoPresentismoB();
// BonoResultado bonoResultado = new BonoResultado();

// Empleado empleado = new Gerente();
// empleado.Inasistencias = 1;
// empleado.ObjetivoCumplido = 100;
// empleado.BonoPresentismo = bonoA;
// empleado.BonoResultado = bonoResultado;

// Administrativo admin = new Administrativo();
// admin.Inasistencias = 1;
// admin.ObjetivoCumplido = 100;
// admin.BonoPresentismo = bonoA;
// admin.BonoResultado = bonoResultado;

// Dictionary<int, Empleado> dicEmpleados = new Dictionary<int, Empleado>();

// dicEmpleados.Add(121212, empleado);
// dicEmpleados.Add(1010, admin);

// if (dicEmpleados.ContainsKey(121212))
//     Console.WriteLine($"El empleado con legajo 121212 tiene un sueldo de ${dicEmpleados[121212].CalcularSueldo()}");
// else
//     Console.WriteLine("No se encontró el empleado con legajo 121212");



// foreach (KeyValuePair<int, Empleado> item in dicEmpleados)
// {
//     Console.WriteLine($"El empleado con legajo {item.Key} tiene un sueldo de ${item.Value.CalcularSueldo()}");
// }

// Console.WriteLine();

// Console.WriteLine($"El empleado tiene un Sueldo de ${empleado.CalcularSueldo()}");

// empleado.BonoPresentismo = bonoB;
// Console.WriteLine($"El empleado tiene un Sueldo de ${empleado.CalcularSueldo()}");

// Empresa objEmpresa = new Empresa();
// //objEmpresa.Empleados = new List<Empleado>();
// objEmpresa.Empleados.Add(empleado);
// objEmpresa.Empleados.Add(admin);


// objEmpresa.InformarSueldos();

//Console.WriteLine("Ahora quitamos el empleado con indice 1");
//objEmpresa.Empleados.RemoveAt(1); //Elimina el indice que le pasamos por parametro en la colección.
// if(objEmpresa.Empleados.Contains(empleado))
//     Console.WriteLine("El empleado sigue en la empresa");
// else
//     Console.WriteLine("El empleado ya no está en la empresa");

// objEmpresa.Empleados.Remove(empleado);

// Empleado objEmpleado = objEmpresa.Empleados.ElementAt(0);
// System.Console.WriteLine("Calculando el sueldo: " +  objEmpleado.CalcularSueldo());


// if(objEmpresa.Empleados.Contains(empleado))
//     Console.WriteLine("El empleado sigue en la empresa");
// else
//     Console.WriteLine("El empleado ya no está en la empresa");


//objEmpresa.InformarSueldos();



public abstract class Empleado
{
    public int Inasistencias { get; set; }
    public float ObjetivoCumplido { get; set; }
    public BonoPresentismo BonoPresentismo { get; set; }
    public BonoResultado BonoResultado { get; set; }

    public abstract float CalcularNeto();

    public float CalcularSueldo()
    {
        return this.CalcularNeto()
            + this.BonoPresentismo.Calcular(this.Inasistencias)
            + this.BonoResultado.Calcular(this.ObjetivoCumplido, this.CalcularNeto());
    }
}

public class Empresa
{
    private List<Empleado> _empleados;
    public List<Empleado> Empleados
    {
        get { return _empleados; }
        set { _empleados = value; }
    }

    public Empresa()
    {
        _empleados = new List<Empleado>();
    }

    public void InformarSueldos()
    {
        foreach (Empleado item in Empleados)
        {
            System.Console.WriteLine(
                item.ToString() + " su sueldo es: " + item.CalcularSueldo().ToString()
            );
        }
    }
}

public class Gerente : Empleado, Imprimible
{
    public override float CalcularNeto()
    {
        return 100000;
    }

    public string Print()
    {
        return "Soy un gerente";
    }

    public override string ToString()
    {
        return "Soy un Gerente";
    }

    public int Legajo { get; set; }

    public override bool Equals(object? obj)
    {
        if (((Gerente)obj).Legajo == this.Legajo)
            return true;
        else
            return false;
    }
}

public class Administrativo : Empleado
{
    public override float CalcularNeto()
    {
        return 500000;
    }
}

public abstract class BonoPresentismo
{
    public abstract float Calcular(int inasistencias);
}

public class BonoPresentismoA : BonoPresentismo
{
    public override float Calcular(int inasistencias)
    {
        if (inasistencias == 0)
            return 1000;
        else if (inasistencias == 1)
            return 450;
        else
            return 0;
    }
}

public class BonoPresentismoB : BonoPresentismo
{
    public override float Calcular(int inasistencias)
    {
        return 500;
    }
}

public class BonoResultado
{
    public float Calcular(float objetivoCumplido, float neto)
    {
        if (objetivoCumplido == 100)
            return (float)0.1 * neto;
        else if (objetivoCumplido >= 80)
            return 800;
        else
            return 0;
    }
}

public interface Imprimible
{
    public string Print();
}

public class Printer
{
    public void Print(Imprimible imprimible)
    {
        Console.WriteLine(imprimible.Print());
    }
}