public class FabricaEscandinava : FabricaAbstracta
{
    public override Mesa CrearMesa()
    {
        Mesa objMesa = new MesaEscandinava();
        objMesa.Estilo = "Mesa estilo Escandinava";
        return objMesa;
    }

    public override Silla CrearSilla()
    {
        Silla objSilla = new SillaEscanvinava();
        objSilla.Estilo = "Silla estilo Escandinava";
        return objSilla;
    }
}