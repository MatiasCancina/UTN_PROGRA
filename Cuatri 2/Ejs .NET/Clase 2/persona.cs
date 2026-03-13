// Persona objPersona = new Persona();
// objPersona.Nombre = "Diego";
// objPersona.Apellido = "Maradona";
// Console.WriteLine(objPersona.Saludar());

Profesor objProfesor = new Profesor();
objProfesor.Nombre = "Leonardo";
objProfesor.Apellido = "Da Vinci";
objProfesor.NumeroDeLegajo = 1234;
Console.WriteLine(objProfesor.Saludar());

Profesor objProfesor2 = new Profesor("Albert", "Einstein", 4321);
Console.WriteLine(objProfesor2.Saludar());

Profesor objProfesor3 = new Profesor("Curie", 5678);
Console.WriteLine(objProfesor3.Saludar());

Alumno objAlumno = new Alumno();
objAlumno.Nombre = "Juan";
objAlumno.Apellido = "Perez";
objAlumno.NumeroDeMatricula = 5678;
Console.WriteLine(objAlumno.Saludar());

Examen objExamen = new Examen(objAlumno, objProfesor, DateTime.Now);

public abstract class Persona
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

    public abstract string Saludar();
}

public class Profesor : Persona
{
    private int numeroDeLegajo;
    public int NumeroDeLegajo
    {
        get { return numeroDeLegajo; }
        set { numeroDeLegajo = value; }
    }

    public override string Saludar()
    {
        return "Hola, soy el profesor " + Nombre + " " + Apellido + " y mi número de legajo es " + NumeroDeLegajo + ".";
    }

    public Profesor() { }

    public Profesor(string apellido, int numeroDeLegajo)
    {
        Apellido = apellido;
        NumeroDeLegajo = numeroDeLegajo;
    }

    public Profesor(string nombre, string apellido, int numeroDeLegajo)
    {
        Nombre = nombre;
        Apellido = apellido;
        NumeroDeLegajo = numeroDeLegajo;
    }
}

public class Alumno : Persona
{
    private int numeroDeMatricula;
    public int NumeroDeMatricula
    {
        get { return numeroDeMatricula; }
        set { numeroDeMatricula = value; }
    }


    public override string Saludar()
    {
        return "Hola, soy el alumno " + Nombre + " " + Apellido + " y mi número de matrícula es " + NumeroDeMatricula + ".";
    }
}

public class Examen(Alumno alumno, Profesor profesor)
{
    public Examen(Alumno alumno, Profesor profesor, DateTime fecha)
    {
        Alumno = alumno;
        Profesor = profesor;
        this.fecha = fecha;
    }

    private int nota;
    public int Nota
    {
        get { return nota; }
        set { nota = value; }
    }

    private DateTime fecha;
    public DateTime Fecha
    {
        get { return fecha; }
        set { fecha = value; }
    }

}