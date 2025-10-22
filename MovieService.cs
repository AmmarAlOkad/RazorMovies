namespace RazorMovies;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public int Year { get; set; }
    public double Rating { get; set; }
    public string Genre { get; set; } = "";
    public string Description { get; set; } = "";
}
public class MovieService
{
    private List<Movie> _movies;

    public MovieService()
    {
        _movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "Inception", Year = 2010, Rating = 8.8, Genre="Sci-Fi", Description="Dream within a dream." },
            new Movie { Id = 2, Title = "The Matrix", Year = 1999, Rating = 8.7, Genre="Sci-Fi", Description="Reality or simulation?" },
            new Movie { Id = 3, Title = "Interstellar", Year = 2014, Rating = 8.6, Genre="Sci-Fi", Description="Love transcends time." },
            new Movie { Id = 4, Title = "The Dark Knight", Year = 2008, Rating = 9.0, Genre="Action", Description="The rise of the Joker." },
            new Movie { Id = 5, Title = "Forrest Gump", Year = 1994, Rating = 8.8, Genre="Drama", Description="Life is like a box of chocolates." },
            new Movie { Id = 6, Title = "Gladiator", Year = 2000, Rating = 8.5, Genre="Action", Description="Are you not entertained?" },
            new Movie { Id = 7, Title = "Titanic", Year = 1997, Rating = 7.8, Genre="Romance", Description="A love story on the ill-fated ship." },
            new Movie { Id = 8, Title = "Pulp Fiction", Year = 1994, Rating = 8.9, Genre="Crime", Description="Nonlinear storytelling masterpiece." },
            new Movie { Id = 9, Title = "Avatar", Year = 2009, Rating = 7.8, Genre="Sci-Fi", Description="The world of Pandora." },
            new Movie { Id = 10, Title = "The Shawshank Redemption", Year = 1994, Rating = 9.3, Genre="Drama", Description="Hope never dies." }
        };
    }
    public List<Movie> GetAllMovies() => _movies;

    public Movie? GetMovieById(int id) => _movies.FirstOrDefault(m => m.Id == id);

    public void AddMovie(Movie m)
    {
        m.Id = _movies.Max(m => m.Id) + 1;
        _movies.Add(m);
    }
}