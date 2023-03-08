using Projekt.Models.Classes;

namespace Projekt.Models.DTO
{
    public class AddScreenTimeDto
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public ScreenTime ScreenTime { get; set; }
    }
}
