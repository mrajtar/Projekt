using Microsoft.VisualStudio.TestTools.UnitTesting;
/*
namespace UnitTests
{
    [TestClass]
    public class MovieDetailsControllerTest
    {
        [TestMethod]
        public void Index_ReturnsViewResult_WhenGivenValidMovieId()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "MovieDetailsDatabase")
                .Options;
            using (var context = new AppDbContext(options))
            {
                var controller = new MovieDetailsController(context);

                var movie = new MovieDetails { Id = 1, Title = "Test Movie" };
                var screenTime = new ScreenTime { Id = 1, MovieId = 1, StartTime = new System.DateTime(2022, 3, 1, 12, 0, 0) };

                context.MovieDetails.Add(movie);
                context.ScreenTimes.Add(screenTime);
                context.SaveChanges();

                // Act
                var result = controller.Index(movie.Id);

                // Assert
                Assert.IsInstanceOfType(result, typeof(ViewResult));
            }
        }
    }
}
*/