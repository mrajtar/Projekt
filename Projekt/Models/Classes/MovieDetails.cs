using Projekt.Data;
using System.ComponentModel.DataAnnotations;

namespace Projekt.Models
{
    public class MovieDetails
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public int ReleaseYear { get; set; }
    }
}
