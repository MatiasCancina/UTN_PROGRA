public abstract class Elemento
{
    string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    } 

    public int Tamaño { get; set; }
    public Elemento(string nombre, int tamaño)
    {
        this.Nombre = nombre;
        this.Tamaño = tamaño;
    }

    public abstract int DevolverTamaño();
}