

public class Persona
{
    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    private string apellido;
    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }

    public virtual string Presentarse()
    {
        return this.Apellido + " " + this.Nombre;
    }
}

public class Visitante : Persona
{
    private int dni;
    public int DNI
    {
        get { return dni; }
        set { dni = value; }
    }

    public override string Presentarse()
    {
        return "Hola, soy " + this.Nombre + " " + this.Apellido + " y soy visitante.";
    }
}

public class Guardia : Persona
{
    public string ControlarDocumento(Visitante visitante)
    {
        return "Adelante, puede pasar " + visitante.Nombre + " " + visitante.Apellido + " con DNI " + visitante.DNI + ".";
    }

    public override string Presentarse()
    {
        return "Hola, soy " + this.Nombre + " " + this.Apellido + " y soy guardia.";
    }

    public Guardia() { }
}