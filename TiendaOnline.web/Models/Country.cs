using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.web.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
