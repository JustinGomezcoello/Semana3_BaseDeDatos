using System.ComponentModel.DataAnnotations;

namespace Semana3_BaseDeDatos.Models
{
    public class Carrera
    {
        [Key]
        public int Id { get; set; }
        public String Nombre { get; set; }

    }
}
