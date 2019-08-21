using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace ChefDishes.Models
{

    public class Chef{
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Birthday { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Dish> ChefsDishes {get;set;}

    }
}