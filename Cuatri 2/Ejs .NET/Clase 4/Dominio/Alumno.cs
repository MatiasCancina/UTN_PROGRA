namespace Dominio
{
    public class Alumno : Persona
    {
        public Alumno(string nombre, string apellido, string email, string legajo, float promedio) : base(nombre, apellido, email)
        {
            this.Legajo = legajo;
            this.Promedio = promedio;
        }

        public string Legajo { get; set; }
        public float Promedio { get; set; }

        public override string Saludar()
        {
            return base.Saludar() + $" y mi legajo es {this.Legajo} y mi promedio es {this.Promedio}";
        }

        public string Saludar(string mensaje)
        {
            return $" Hola, soy un alumno ({this.Legajo}) con promedio {this.Promedio} y mi nombre es {this.GetNombre()} {this.GetApellido()} y mi email es {this.GetEmail()} y el mensaje es: {mensaje}";
        }

        public bool EstoyPresente()
        {
            return true;
        }
    }
}