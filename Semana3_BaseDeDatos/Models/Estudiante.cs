using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Semana3_BaseDeDatos.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        public string Nombre { get; set; }
        [EmailAddress]
        public string? Correo    { get; set; }
        public DateTime FechaNacimiento     { get; set; }   
        public Boolean TieneBeca { get; set; }
        public Carrera Carrera { get; set; }
        [ForeignKey("Carrera")]
        public int IdCarrera { get; set; }



    }
}
