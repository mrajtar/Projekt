using Projekt.Models.Classes;

namespace Projekt.Models.DTO
{
    public class MovieDetailsDto
    {
        public MovieDetails Movie { get; set; }

        public IEnumerable<ScreenTime> ScreenTime { get; set; }
    }
}
