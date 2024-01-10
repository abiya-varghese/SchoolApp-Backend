using Assignment9.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace Assignment9.Repository
{
    public class MovieRepostiory : IMovieRepository
    {
        public List<Movie> movies=new List<Movie>();
        public void AddMovie(Movie movie)
        {
            try
            {
                movies.Add(movie);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Movie> GetAllMovie()
        {
            try
            {
                return movies;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Movie> GetMoviesByActor(string act)
        {
            try
            {
                List<Movie> movieActor = new List<Movie>();
                foreach(var item in movies)
                {
                    if(item.Actor == act)
                        movieActor.Add(item);
                }
                return movieActor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Movie> GetMoviesByDirector(string dir)
        {
            try
            {
                List<Movie> movieActor = new List<Movie>();
                foreach (var item in movies)
                {
                    if (item.Director == dir)
                        movieActor.Add(item);
                }
                return movieActor;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<Movie> GetMoviesByReleaseYear(string year)
        {
            try
            {
                List<Movie> movieActor = new List<Movie>();
                foreach (var item in movies)
                {
                    if (item.ReleaseYear == year)
                        movieActor.Add(item);
                }
                return movieActor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Movie GetMoviesByName(string name)
        {
            try
            {
                foreach (var item in movies)
                {
                    if (item.MovieName == name)
                    {
                        return item;
                    }
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
