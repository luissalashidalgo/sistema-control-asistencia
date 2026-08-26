using System.ComponentModel.DataAnnotations;

namespace ControlAsistencia.Api.Entities
{
    public class Persona
    {
        public int Id { get; set; }
        [Required]
        public string Cedula { get; set; } = string.Empty;
        [Required]
        public string Nombre { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
    }
}
