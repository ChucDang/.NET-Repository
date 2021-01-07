using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [Range(1, 100), DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
}
