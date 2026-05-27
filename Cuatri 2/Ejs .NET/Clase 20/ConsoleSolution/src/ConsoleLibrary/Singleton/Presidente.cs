namespace ConsoleLibrary;

public class Presidente
{

    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    private string _apellido;
    public string Apellido
    {
        get { return _apellido; }
        set { _apellido = value; }
    }


    private static Presidente _instancia;

    public static Presidente DevolverInstancia()
    {
        if (_instancia == null)
        {
            _instancia = new Presidente();
        }

        return _instancia;
    }
    

    public static void  Eleccion (string nombreNuevoPresidente, string apellidoNuevoPresidente)
    {
        if (_instancia == null)
        {
            _instancia = new Presidente();
        }
        _instancia.Nombre = nombreNuevoPresidente;
        _instancia.Apellido = apellidoNuevoPresidente;
    } 

    private Presidente()
    {

        Nombre = "";
        Apellido = "";
    }

}
