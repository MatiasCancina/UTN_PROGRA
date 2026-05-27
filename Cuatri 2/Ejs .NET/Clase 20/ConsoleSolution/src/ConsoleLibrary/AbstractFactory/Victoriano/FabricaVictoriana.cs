public class FabricaVictoriana : FabricaAbstracta
{
    public override Mesa CrearMesa()
    {
        MesaVictoriana objMesa = new MesaVictoriana();
        objMesa.Estilo = "Mesa Victoriana";
        return objMesa;
    }

    public override Silla CrearSilla()
    {
        return new SillaVictoriana();
    }
}