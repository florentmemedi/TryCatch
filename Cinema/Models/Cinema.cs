using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaLab.Models
{
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }

        public Cinema()
        {
            Halls = new List<int>();
            ListOfMovies = new List<Movie>();
        }
        public Cinema(string name)
        {
            Name = name;
        }
        public string MoviePlaying(Movie movie)
        {
            return $"Watching movie: {movie.Title}";
        }
    }
}
