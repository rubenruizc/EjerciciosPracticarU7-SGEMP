namespace EjerciciosPracticarU7_SGEMP.Models
{
    public class clsPersona
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Apellido { get; set; }

        public DateTime fechaNacimiento { get; set; }

        public clsPersona() { }

        public clsPersona(int id, string name, string apellido, DateTime fechaNacimiento)
        {
            Id = id;
            Name = name;
            Apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
        }
    }
}
