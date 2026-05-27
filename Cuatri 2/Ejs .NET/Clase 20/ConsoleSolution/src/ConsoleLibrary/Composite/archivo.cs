public class Archivo : Elemento
{
    public Archivo(string nombre, int tamaño) : base(nombre, tamaño)
    {
        
    }

    public override int DevolverTamaño()
    {
        return this.Tamaño;
    }
}