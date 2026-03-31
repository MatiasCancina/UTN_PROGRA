HashSet<Empleado> unicos = new HashSet<Empleado>();

Gerente objGerente = new Gerente();
objGerente.Legajo = 1234;
unicos.Add(objGerente);

Gerente nuevoGerente = new Gerente();
nuevoGerente.Legajo = 1234;
unicos.Add(nuevoGerente);
unicos.Add(new Administrativo());

Console.WriteLine(unicos.Contains(objGerente));

unicos.Remove(objGerente);

foreach (Empleado item in unicos)
{
    Console.WriteLine(item.ToString());
}

// BonoPresentismo bonoA = new BonoPresentismoA();
// BonoPresentismo bonoB = new BonoPresentismoB();
// BonoResultado bonoResultado = new BonoResultado();

// Empleado empleado = new Gerente();
// empleado.Inasistencias = 1;
// empleado.ObjetivoCumplido = 100;
// empleado.BonoPresentismo = bonoA;
// empleado.BonoResultado = bonoResultado;

// Administrativo admin = new Administrativo();
// admin.Inasistencias = 0;
// admin.ObjetivoCumplido = 50;
// admin.BonoPresentismo = bonoA;
// admin.BonoResultado = bonoResultado;

Dictionary<int, Empleado> dicEmpleados = new Dictionary<int, Empleado>();
// dicEmpleados.Add(121212, empleado);
// dicEmpleados.Add(101010, admin);

// if (dicEmpleados.ContainsKey(121212))
// {
//     Console.WriteLine($"El empleado con legajo 121212 tiene un sueldo de {dicEmpleados[121212].CalcularSueldo()}");
// }
// else
// 
{//     Console.WriteLine($"No se encontro el empleado con legajo 121212"); // 
}
// 
foreach (KeyValuePair<int, Empleado> item in dicEmpleados)// 
{// 
    Console.WriteLine($"El empleado con legajo {item.Key} tiene un sueldo de {item.Value.CalcularSueldo()}");// 
}

// Console.WriteLine($"El empleado tiene un sueldo de {empleado.CalcularSueldo()}");

// empleado.BonoPresentismo = bonoB;
// Console.WriteLine($"El empleado tiene un sueldo de {empleado.CalcularSueldo()}");

// Empresa objEmpresa = new Empresa();
// objEmpresa.Empleados = new List<Empleado>();
// objEmpresa.Empleados.Add(empleado);
// objEmpresa.Empleados.Add(admin);

// objEmpresa.InformarSueldo();

// Console.WriteLine("Elimino el empleado con indice 1");
// objEmpresa.Empleados.RemoveAt(1);
// if (objEmpresa.Empleados.Contains(admin))
//     Console.WriteLine("El empleado sigue en la empresa");
// else
//     Console.WriteLine("El empleado ya no esta en la empresa");

// objEmpresa.Empleados.Remove(admin);

// Empleado objEmpleado = objEmpresa.Empleados.ElementAt(0);
// Console.WriteLine("Calculando el sueldo... " + objEmpleado.CalcularSueldo());

// if (objEmpresa.Empleados.Contains(admin))
//     Console.WriteLine("El empleado sigue en la empresa");
// else
//     Console.WriteLine("El empleado ya no esta en la empresa");

public abstract class Empleado
{
    public int Inasistencias { get; set; }
    public float ObjetivoCumplido { get; set; }
    public BonoPresentismo BonoPresentismo { get; set; }
    public BonoResultado BonoResultado { get; set; }

    public abstract float CalcularNeto();

    public float CalcularSueldo()
    {
        return this.CalcularNeto() + this.BonoPresentismo.Calcular(this.Inasistencias) + this.BonoResultado.Calcular(this.ObjetivoCumplido, this.CalcularNeto());
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

    public void InformarSueldo()
    {
        foreach (Empleado item in Empleados)
        {
            Console.WriteLine($"El sueldo del empleado es: {item.CalcularSueldo()} ({item.ToString()})");
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
        return $"Soy un Gerente";
    }

    public string toSring()
    {
        return $"Soy un Gerente";
    }


    public int Legajo { get; set; }

    public override bool Equals(object? obj)
    {
        if (((Gerente)obj).Legajo is this.Legajo)
            return true;

        return false;
    }

}

public class Administrativo : Empleado
{
    public override float CalcularNeto()
    {
        return 500000;
    }

    public override string ToString()
    {
        return "Soy un Administrativo";
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
            return 100;
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