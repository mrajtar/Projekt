using Projekt.Data;

namespace Projekt.Models
{
    public class MovieDetails
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ImageURL { get; set; }
        public MovieCategory MovieCategory { get; set; }

    }
}
