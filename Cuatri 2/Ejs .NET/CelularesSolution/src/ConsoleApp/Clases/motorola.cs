namespace Clases
{
    public class Motorola : Celular
    {
        public override void PerdidaDeBateria(int duracion)
        {
            this.Bateria.PuntosDeBateria -= 0.25;
        }
    }
}