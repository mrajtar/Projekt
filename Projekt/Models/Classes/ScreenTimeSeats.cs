namespace Projekt.Models.Classes
{
    public class ScreenTimeSeats
    {
        public int Id { get; set; }
        public int ScreenTimeId { get; set; }
        public ScreenTime ScreenTime { get; set; }
        public int SeatId { get; set; }
        public Seat Seat { get; set; }
        public bool IsReserved { get; set; }
        public Guid ScreenTimeSeatTicketId { get; set; }
    }
}
