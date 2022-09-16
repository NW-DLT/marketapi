using System.ComponentModel.DataAnnotations;

namespace back4ker4.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
