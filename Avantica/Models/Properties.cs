using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Avantica.Models
{
    [Table("Properties", Schema = "dbo")]
    public class Properties
    {
        [Key]
        [Required]
        public string Address { get; set; }
        [Required]
        public int? Year_Built { get; set; }
        [Required]
        public string List_Price { get; set; }
        [Required]
        public string Monthly_Rent { get; set; }
        [Required]
        public string Gross_Yield { get; set; }
    }
}
