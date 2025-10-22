using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorMovies.Pages
{
    public class MovieDetailsModel : PageModel
    {
        private MovieService _movieService;
        public Movie movie { get; set; }

        public MovieDetailsModel(MovieService movieService)
        {
            _movieService = movieService;
        }
        //public void OnGet(int id)
        //{
        //    movie = _movieService.GetMovieById(id);
        //}
        public IActionResult OnGet(int id)
        {
            movie = _movieService.GetMovieById(id);
            if (movie == null) return NotFound();

            return Page();
        }
    }
}
