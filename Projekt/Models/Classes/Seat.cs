namespace Projekt.Models.Classes
{
    public class Seat
    {
        public int SeatId { get; set; }
        public string SeatName { get; set; }
        public bool IsReserved { get; set; } = false;
    }
}
