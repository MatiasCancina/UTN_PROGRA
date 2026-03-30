BonoPresentismo bonoA = new BonoPresentismoA();
BonoPresentismo bonoB = new BonoPresentismoB();
BonoResultado bonoResultado = new BonoResultado();

Empleado empleado = new Gerente();
empleado.Inasistencias = 1;
empleado.ObjetivoCumplido = 100;
empleado.BonoPresentismo = bonoA;
empleado.BonoResultado = bonoResultado;

Administrativo admin = new Administrativo();
admin.Inasistencias = 0;
admin.ObjetivoCumplido = 50;
admin.BonoPresentismo = bonoA;
admin.BonoResultado = bonoResultado;

Console.WriteLine($"El empleado tiene un sueldo de {empleado.CalcularSueldo()}");

empleado.BonoPresentismo = bonoB;
Console.WriteLine($"El empleado tiene un sueldo de {empleado.CalcularSueldo()}");

List<Empleado> empleados = new List<Empleado>();
empleados.Add(admin);
empleados.Add(empleado);

foreach (Empleado item in empleados)
{
    Console.WriteLine($"El sueldo del empleado es: {item.CalcularSueldo()} ({item.ToString()})");
}

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
}

public class Administrativo : Empleado
{
    public override float CalcularNeto()
    {
        return 500000;
    }

    public string toSring()
    {
        return $"Soy un Administrativo";
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