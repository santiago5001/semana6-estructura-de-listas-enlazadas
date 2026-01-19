namespace TareaListas
{
    public class Estudiante
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public double NotaDefinitiva { get; set; }

        public Estudiante(string cedula, string nombre, string apellido, string correo, double nota)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            NotaDefinitiva = nota;
        }

        public override string ToString()
        {
            return $"Cédula: {Cedula} | {Nombre} {Apellido} | Nota: {NotaDefinitiva}";
        }
    }
}