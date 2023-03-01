using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using Projekt.Models;
using Projekt.Models.Classes;
using Projekt.Models.DTO;
using System.Linq;

namespace Projekt.Controllers
{
    public class TicketsController : Controller
    {
        private AppDbContext _context;

        public TicketsController(AppDbContext context)
        {
            _context = context;

        }
        
        public IActionResult SelectTickets(int screenTimeId, int movieId)
        {
            Cinema cinema = _context.Cinema.First();
            List<ScreenTimeSeats> screenTimeSeats = 
                _context.ScreenTimeSeats.Include(s => s.Seat).Include(s => s.ScreenTime)
                .Where(sts => sts.ScreenTimeId == screenTimeId)
                .ToList();
            MovieDetails movie = _context.MovieDetails.FirstOrDefault(m => m.Id == movieId);
            ScreenTime screenTime = _context.ScreenTimes.FirstOrDefault(m => m.Id == screenTimeId);
            CinemaBookMovieDto cinemaMovieDto = new CinemaBookMovieDto()
            {
                Movie = movie,
                Cinema = cinema,
                ScreenTime = screenTime,
                ScreenTimeSeats = screenTimeSeats
            };

            return View("Tickets", cinemaMovieDto);
        }

        public IActionResult BuyTickets(string[] selectedSeats, string userEmail, string movieName, string screenDateTime)
        {
            Cinema cinema = _context.Cinema.First();
            List<ScreenTimeSeats> seatsToReserve = new List<ScreenTimeSeats>();
            foreach (var seatId in selectedSeats)
            {
                seatsToReserve.Add(_context.ScreenTimeSeats.Include(s => s.Seat).Include(s => s.ScreenTime)
                    .FirstOrDefault(s => s.SeatId == Convert.ToInt32(seatId)));
            }

            Guid ticketId = Guid.NewGuid();
            foreach (ScreenTimeSeats seat in seatsToReserve)
            {
                seat.IsReserved = true;
                seat.ScreenTimeSeatTicketId = ticketId;
                _context.Update(seat);
            }
            _context.SaveChanges();

            TicketsPucharseDto ticketsPurchaseDto = new TicketsPucharseDto()
            {
                MovieTitle = movieName,
                ScreenDateTime = screenDateTime,
                UserEmail = userEmail,
                ReservationId = ticketId,
                SelectedSeats = seatsToReserve
            };

            return View("TicketsPurchase", ticketsPurchaseDto);
        }

        public IActionResult CancelReservation()
        {
            return View("CancelReservation");
        }

        public IActionResult CancelReservationAction(string userEmail, Guid reservationId)
        {
            List<ScreenTimeSeats>? reservations = _context.ScreenTimeSeats.Where(s => s.ScreenTimeSeatTicketId == reservationId)?.ToList();
            if (reservations.Any())
            {
                foreach (var reservation in reservations)
                {
                    reservation.IsReserved = false;
                    reservation.ScreenTimeSeatTicketId = Guid.Empty;
                    _context.Update(reservation);
                }

                _context.SaveChanges();
                TempData["msg"] = "Reservations cancelled, thank you";
            }

            return View("CancelReservation");
        }
    }
}
