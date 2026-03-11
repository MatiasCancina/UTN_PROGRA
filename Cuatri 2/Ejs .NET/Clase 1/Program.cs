Console.WriteLine("Hello, World!");

Persona unaPersona = new Alumno("12345", 8.5f);

unaPersona.SetNombre("Juan");
unaPersona.SetApellido("Perez");
unaPersona.SetEmail("juan.perez@gmail.com");

Console.WriteLine(unaPersona.Saludar()); //cout << unaPersona.saludar()

public abstract class Persona
{
    private string nombre;

    private string apellido;
    private string email;

    public string GetNombre()
    {
        return this.nombre;
    }

    public string GetApellido()
    {
        return this.apellido;

    }

    public string GetEmail()
    {
        return this.email;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public void SetApellido(string apellido)
    {
        if (apellido != this.nombre)
        {
            this.apellido = apellido;

        }
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }

    public virtual string Saludar()
    {
        return $"Hola, mi nombre es {this.nombre} {this.apellido} y mi email es {this.email}";
    }
}

public class Alumno : Persona
{
    public Alumno(string legajo, float promedio)
    {
        this.Legajo = legajo;
        this.Promedio = promedio;
    }

    public string Legajo { get; set; }
    public float Promedio { get; set; }

    public override string Saludar()
    {
        return $"Hola, soy un alumno ({this.Legajo}) con promedio {this.Promedio} y mi nombre es {this.GetNombre()} {this.GetApellido()} y mi email es {this.GetEmail()}";
    }
}