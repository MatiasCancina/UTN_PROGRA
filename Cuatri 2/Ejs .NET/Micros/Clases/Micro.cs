namespace _20260414___Clase_09.Clases;

using System.Collections.Generic;
using System;

public class Micro
{
    public int LugaresLibres()
    {
        return (CantidadSentados + CantidadParados) - Pasajeros.Count;
    }
    public Micro(int volumen, int cantidadAsientos, int cantidadParados)
    {
        _volumen = volumen;
        _cantidadSentados = cantidadAsientos;
        _cantidadParados = cantidadParados;
        _pasajeros = new List<Persona>();
    }
    private int _cantidadSentados;
    public int CantidadSentados
    {
        get { return _cantidadSentados; }
        set { _cantidadSentados = value; }
    }

    private int _cantidadParados;
    public int CantidadParados
    {
        get { return _cantidadParados; }
        set { _cantidadParados = value; }
    }

    private int _volumen;
    public int Volumen
    {
        get { return _volumen; }
        set { _volumen = value; }
    }

    private List<Persona> _pasajeros;
    public List<Persona> Pasajeros
    {
        get { return _pasajeros; }
        set { _pasajeros = value; }
    }

    public bool HayLugar()
    {
        return (CantidadSentados + CantidadParados) > Pasajeros.Count;
    }

    public int HayLugaresLibres()
    {
        return (CantidadSentados + CantidadParados) - Pasajeros.Count;
    }

    public bool HayLugarSentados()
    {
        return CantidadSentados > Pasajeros.Count;
    }

    public void Subir(Persona persona)
    {
        if (persona.AceptaSubir(this))
        {
            Console.WriteLine("La persona ha subido al micro.");
            Pasajeros.Add(persona);
        }
        else
        {
            Console.WriteLine("La persona no se ha subido al micro.");
        }
    }
}