public class Robot
{
    public string MostrarInformacion()
    {
        return "Número de serie: " + this.NroSerie + ", Potencia base: " + this.PotenciaBase + ", Tipo de tracción: " + this.TipoTraccion.GetType().Name + " - Autonmia: " + this.TipoTraccion.Autonomia + " - Desgaste por uso: " + this.TipoTraccion.DesgastePorUso;
    }

    private string _nroSerie;
    public string NroSerie
    {
        get { return _nroSerie; }
        set { _nroSerie = value; }
    }

    private int _potenciaBase;
    public int PotenciaBase
    {
        get { return _potenciaBase; }
        set { _potenciaBase = value; }
    }

    private TipoTraccion _tipoTraccion;
    public TipoTraccion TipoTraccion
    {
        get { return _tipoTraccion; }
        set { _tipoTraccion = value; }
    }

    public void Recorrer(int distancia)
    {
        this.PotenciaBase = this.PotenciaBase - this.TipoTraccion.DesgastePorUso;
    }

    public Robot(string nroSerie, int potenciaBase, TipoTraccion tipoTraccion)
    {
        this.NroSerie = nroSerie;
        this.TipoTraccion = tipoTraccion;
        this.PotenciaBase = potenciaBase;
    }
}

public abstract class TipoTraccion
{
    private int _desgastePorUso;
    public int DesgastePorUso
    {
        get { return _desgastePorUso; }
        set { _desgastePorUso = value; }
    }

    private int _autonomia;
    public int Autonomia
    {
        get { return _autonomia; }
        set { _autonomia = value; }
    }
}

public class RuedaDeCaucho : TipoTraccion
{
    public RuedaDeCaucho()
    {
        this.DesgastePorUso = 1;
        this.Autonomia = 100;
    }
}

public class Oruga : TipoTraccion
{
    private string _sensor;
    public string Sensor
    {
        get { return _sensor; }
        set { _sensor = value; }
    }

    public Oruga()
    {
        this.DesgastePorUso = 3;
        this.Autonomia = 400;
        this.Sensor = "Sensor de presión";
    }
}