using Projekt.Models.Classes;

namespace Projekt.Models.DTO
{
    public class TicketsPucharseDto
    {
        public List<ScreenTimeSeats> SelectedSeats { get; set; }
        public string MovieTitle { get; set; }
        public string UserEmail { get; set; }
        public string ScreenDateTime { get; set; }
        public Guid ReservationId { get; set; }
    }
}
