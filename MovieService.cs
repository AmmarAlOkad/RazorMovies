namespace RazorMovies;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public int Year { get; set; }
    public double Rating { get; set; }
}
public class MovieService
{
    public List<Movie> Movies;

    public MovieService()
    {
        Movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "The Matrix", Year = 1999, Rating = 8.7 },
            new Movie { Id = 2, Title = "Inception", Year = 2010, Rating = 8.8 },
            new Movie { Id = 3, Title = "Interstellar", Year = 2014, Rating = 8.6 },
            new Movie { Id = 4, Title = "Pulp Fiction", Year = 1994, Rating = 8.9 },
            new Movie { Id = 5, Title = "The Godfather", Year = 1972, Rating = 9.2 },
            new Movie { Id = 6, Title = "Forrest Gump", Year = 1994, Rating = 8.8 },
            new Movie { Id = 7, Title = "Fight Club", Year = 1999, Rating = 8.8 },
            new Movie { Id = 8, Title = "The Shawshank Redemption", Year = 1994, Rating = 9.3 },
            new Movie { Id = 9, Title = "The Dark Knight", Year = 2008, Rating = 9.0 },
            new Movie { Id = 10, Title = "Gladiator", Year = 2000, Rating = 8.5 }
        };
    }
    public List<Movie> GetAllMovies()
    {
        return Movies;
    }
}