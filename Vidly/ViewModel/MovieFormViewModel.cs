using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleasedDate { get; set; }
        [Required]
        [Display(Name = "Number In Stock")]
        [RegularExpression("([0-9][0-9]*)", ErrorMessage = "Number in stock must be a natural number")]
        [Range(1, 20, ErrorMessage = "The field Number In Stock must be between 1 and 20")]
        public int? NumberInStock { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        public string Title
        {
            get { return (Id != 0) ? "Edit Movie" : "New Movie"; }
        }
        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleasedDate = movie.ReleasedDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}