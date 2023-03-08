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
        
        public IActionResult ScreenTime(int movieId)
        {
            MovieDetails movie = _context.MovieDetails.FirstOrDefault(m => m.Id == movieId);
            AddScreenTimeDto addScreenTimeDto = new AddScreenTimeDto()
            {
                MovieId = movieId,
                MovieTitle = movie.Title,
                ScreenTime = new ScreenTime()
            };

            return View("AddScreenTime", addScreenTimeDto);
        }

        [HttpPost]
        public IActionResult AddScreenTime(AddScreenTimeDto addScreenTimeDto)
        {

            var screenTime = new ScreenTime
            {
                MovieId = addScreenTimeDto.MovieId,
                ScreenDateTime = addScreenTimeDto.ScreenTime.ScreenDateTime
            };
            _context.Add(screenTime);
            _context.SaveChanges();
            ViewBag.Message = "Screening time was successfully added.";
            return View("AddScreenTime", addScreenTimeDto);
        }
        [HttpPost]
        public IActionResult DeleteScreenTime(int screenTimeId)
        {
            var screenTime = _context.ScreenTimes.FirstOrDefault(s => s.Id == screenTimeId);
            if (screenTime != null)
            {
                _context.ScreenTimes.Remove(screenTime);
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
