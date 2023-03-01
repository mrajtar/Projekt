using Projekt.Models.Classes;

namespace Projekt.Models.DTO
{
    public class CinemaBookMovieDto
    {
        public Cinema Cinema { get; set; }
        public MovieDetails Movie { get; set; }
        public ScreenTime ScreenTime { get; set; }
        public List<ScreenTimeSeats> ScreenTimeSeats { get; set; }
    }
}
