namespace Projekt.Models.Classes
{
    public class ScreenTime
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public MovieDetails Movie { get; set; }
        public DateTime ScreenDateTime { get; set; }
    }
}
