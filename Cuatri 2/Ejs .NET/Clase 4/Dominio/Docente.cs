namespace Dominio
{
    public class Docente : Persona
    {
        private string _materia;
        public string Materia
        {
            get { return this._materia; }
            set { this._materia = value; }
        }

        public int Horas { get; set; }

        public Docente(string materia, int horas)
        {
            this.Materia = materia;
            this.Horas = horas;
        }

        public override string Saludar()
        {
            return $"Hola, soy un docente y mi nombre es {this.GetNombre()} {this.GetApellido()} y mi email es {this.GetEmail()} y enseño la materia {this.Materia} con {this.Horas} horas semanales";
        }
    }
}