using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.DTOs
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public DateTime ReleasedDate { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "Number in stock must be a natural number")]
        [Range(1, 20, ErrorMessage = "The field Number In Stock must be between 1 and 20")]
        public int NumberInStock { get; set; }
        [Required]
        public byte GenreId { get; set; }
        public GenreDto Genre { get; set; }
    }
}