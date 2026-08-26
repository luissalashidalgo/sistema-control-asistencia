using System.ComponentModel.DataAnnotations;

namespace ControlAsistencia.Api.Entities
{
    public class Empleado
    {
        public int Id { get; set; }
        [Required]
        public Persona Persona { get; set; } = new Persona();

        [Required]
        public string CodigoInterno { get; set; } = string.Empty;

        public string Cargo { get; set; } = string.Empty;


        public string Departamento { get; set; } = string.Empty;

        [Required] 
        public bool Estado { get; set; } = false; //True = Activo, False = Inactivo
    }
}
