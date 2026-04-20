namespace _20260414___Clase_09.Clases;


public abstract class Persona
{
    private bool _esJefe;
    public bool EsJefe
    {
        get { return _esJefe; }
        set { _esJefe = value; }
    }

    private Persona _Jefe;
    public Persona Jefe
    {
        get { return _Jefe; }
        set { _Jefe = value; }
    }

    public abstract bool AceptaSubir(Micro micro);
}