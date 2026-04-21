namespace Clases
{
    public class Iphone : Celular
    {
        public override void PerdidaDeBateria(int duracion)
        {
            this.Bateria.PuntosDeBateria -= duracion * 0.001;
        }
    }
}