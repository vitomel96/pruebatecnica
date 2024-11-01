namespace PersonasAPI.Domain.Entities
{
    public class Persona
    {
        public int Id { get; set; }
        public string Cedula { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string NumeroCelular { get; set; } = string.Empty;
    }
}
