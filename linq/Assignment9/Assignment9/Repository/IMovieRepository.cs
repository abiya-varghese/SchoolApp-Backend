using Assignment9.Models;

namespace Assignment9.Repository
{
    public interface IMovieRepository
    {
        public void AddMovie(Movie movie);
        List<Movie> GetAllMovie();
        Movie GetMoviesByName(string name);
        List<Movie> GetMoviesByActor(string act);
        List<Movie> GetMoviesByReleaseYear(string year);
        List<Movie> GetMoviesByDirector(string dir);
    }
}
