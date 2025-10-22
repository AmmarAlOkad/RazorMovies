using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorMovies.Pages
{
    public class AddMovieModel : PageModel
    {
        private readonly MovieService _movieService;

        [BindProperty]
        public Movie NewMovie { get; set; } = new();

        public AddMovieModel(MovieService movieService)
        {
            _movieService = movieService;
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            _movieService.AddMovie(NewMovie);
            return RedirectToPage("index");
        }
    }
}
