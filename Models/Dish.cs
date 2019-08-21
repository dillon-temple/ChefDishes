using System.ComponentModel.DataAnnotations;
using System;
namespace ChefDishes.Models
{

    public class Dish
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0, 50000)]
        public int Calories { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Tastiness { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        
        [Required]
        public int ChefId { get; set; }
        public Chef Creator {get; set;}
    }
}