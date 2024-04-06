using System.ComponentModel.DataAnnotations;

namespace NetCore.Models
{
    public class Book
    {
        [Key]

        public int Id { get; set; }

        [Required]

        public string Nom { get; set; }
        public string Autor { get; set; }
        public int ISBN { get; set; }
    }
}