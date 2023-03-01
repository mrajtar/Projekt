using Microsoft.AspNetCore.Mvc;
using Projekt.Data;
using Projekt.Models;
using Projekt.Models.Classes;
using Projekt.Models.DTO;

namespace Projekt.Controllers
{
    public class MovieDetailsController : Controller
    {
        private readonly AppDbContext _context;
        public MovieDetailsController (AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int movieId)
        {
            MovieDetails movie = _context.MovieDetails.FirstOrDefault(m => m.Id == movieId);
            List<ScreenTime> screenTimes = new List<ScreenTime>();
            screenTimes = _context.ScreenTimes.Where(st => st.MovieId == movieId).ToList();
            MovieDetailsDto movieDetailsDto = new MovieDetailsDto()
            {
                Movie = movie,
                ScreenTime = screenTimes
            };

            return View(movieDetailsDto);
        }
    }
}
