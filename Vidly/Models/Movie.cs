using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleasedDate { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        [Display(Name = "Number In Stock")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Number in stock must be a natural number")]
        public int NumberInStock { get; set; }
        public Genre Genre { set; get; }
        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

    }
}