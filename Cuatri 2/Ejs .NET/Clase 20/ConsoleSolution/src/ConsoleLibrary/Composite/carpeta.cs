public class Carpeta : Elemento
{


    private List<Elemento> _elementos;
    
    public Carpeta(string nombre, int tamaño) : base(nombre, tamaño)
    {
        this._elementos = new List<Elemento>();
    }

    public void Agregar(Elemento elemento)
    {
        this._elementos.Add(elemento);
    }

    public void Remover (Elemento elemento)
    {
        this._elementos.Remove(elemento);
    }
    public override int DevolverTamaño()
    {
        int tamañoTotal = 0;

        foreach (Elemento elemento in this._elementos)
        {
            tamañoTotal += elemento.DevolverTamaño();
        }
        return tamañoTotal + this.Tamaño;
    }
}