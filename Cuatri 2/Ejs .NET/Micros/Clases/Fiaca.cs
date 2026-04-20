namespace _20260414___Clase_09.Clases;

public class Fiaca : Persona
{
    public override bool AceptaSubir(Micro micro)
    {
        if (micro.HayLugarSentados())
        {
            return true;
        }
        return false;

    }
}