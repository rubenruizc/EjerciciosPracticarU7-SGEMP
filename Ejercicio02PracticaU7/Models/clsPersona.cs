namespace Ejercicio02PracticaU7.Models
{
    public class clsPersona
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Apellido { get; set; }

        public clsPersona() { }

        public clsPersona (int id, string name, string apellido)
        {
            Id = id;
            Name = name;
            Apellido = apellido;
            
        }
    }
}
