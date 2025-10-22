using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorMovies.Pages
{
    public class IndexModel : PageModel
    {
        private MovieService _movieService { get; set; }
        public List<Movie> movies { get; set; } = new();

        public IndexModel(MovieService movieservices)
        {
            _movieService = movieservices;
        }

        public void OnGet()
        {
            movies = _movieService.GetAllMovies();
        }
    }
}
