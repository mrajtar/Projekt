namespace Projekt.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string SeatNumber { get; set; }
        public string UserId { get; set; }
        public DateTime Date { get; set; }
        public int AmountOfTickets { get; set; }
        public int MovieId { get; set; }

    }
}
