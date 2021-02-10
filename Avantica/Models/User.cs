using System.ComponentModel.DataAnnotations;

namespace Avantica.Models
{
    public class User
    {
        [Key]
        [Required]
        public string Id { get; set; }
        [Required]
        public int? Nombre { get; set; }
        [Required]
        public string Apellido  { get; set; }
    }
}
