using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaLab.Models;
using CinemaLab.Enums;

namespace CinemaLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4, 2.5);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 4, 2.5);
            Movie movie3 = new Movie("Saw", Genre.Horror, 4, 2.5);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 4, 2.5);
            Movie movie5 = new Movie("Rambo", Genre.Action, 4, 2.5);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 4, 2.5);
            Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4, 2.5);
            Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4, 2.5);
            Movie movie9 = new Movie("Passengers", Genre.SciFi, 4, 2.5);
            Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4, 2.5);

            List<Movie> MovieSet1 = new List<Movie>()
            { movie1, movie2, movie3, movie4, movie5,
              movie6, movie7, movie8, movie9, movie10 };
            Movie movie11 = new Movie("Airplane", Genre.Comedy, 4, 2.5);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4, 2.5);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 4, 2.5);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 4, 2.5);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 4, 2.5);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4, 2.5);
            Movie movie17 = new Movie("The Social Network", Genre.Drama, 4, 2.5);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4, 2.5);
            Movie movie19 = new Movie("Inception", Genre.SciFi, 4, 2.5);
            Movie movie20 = new Movie("Avatar", Genre.SciFi, 4, 2.5);

            List<Movie> MovieSet2 = new List<Movie>()
            { movie11, movie12, movie13, movie14, movie15,
              movie16, movie17, movie18, movie19, movie20 };


            Cinema cinema1 = new Cinema("Cineplex");
            cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
            cinema1.ListOfMovies = MovieSet1;
            Cinema cinema2 = new Cinema("Milenium");
            cinema2.Halls = new List<int>() { 1, 2 };
            cinema2.ListOfMovies = MovieSet2;

            try
            {
                Console.WriteLine($"Choose your cinema: \n1) {cinema1.Name} \n2) {cinema2.Name}");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    MyMethod(cinema1);
                }
                else if (input == "2")
                {
                    MyMethod(cinema2);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void MyMethod(Cinema cinema)
        {
            Console.WriteLine("Please choose one: movies or genre?");
            string inputMoviesOrGenre = Console.ReadLine();

            if (inputMoviesOrGenre == "movies")
            {
                foreach (var movies in cinema.ListOfMovies)
                {
                    Console.WriteLine(movies.Title);
                }
                string inputMovie = Console.ReadLine();
                cinema.MoviePlaying(cinema.ListOfMovies.Where(movie => movie.Title.ToLower() == inputMovie.ToLower()).FirstOrDefault());

            }
            else if (inputMoviesOrGenre == "genre")
            {
                Console.WriteLine($"Choose Genre: \n1){Genre.Comedy}, \n2){Genre.Horror}, \n3){Genre.Action}, \n4){Genre.Drama}, \n5){Genre.SciFi}");
                string inputGenre = Console.ReadLine();
                Genre GGenre = new Genre();
                switch (inputGenre)
                {
                    case "1":
                        GGenre = Genre.Comedy;
                        break;
                    case "2":
                        GGenre = Genre.Horror;
                        break;
                    case "3":
                        GGenre = Genre.Action;
                        break;
                    case "4":
                        GGenre = Genre.Drama;
                        break;
                    case "5":
                        GGenre = Genre.SciFi;
                        break;
                    default:
                        throw new Exception("Please enter a correct input for genre!");
                }
                Console.WriteLine("Please choose a movie to watch: ");
                List<Movie> personMovies = new List<Movie>();
                foreach (var movie in cinema.ListOfMovies.Where(movie => movie.Genre == GGenre).ToList())
                {
                    personMovies.Add(movie);
                    Console.WriteLine(movie.Title);
                }
                string inputMovie = Console.ReadLine();
                cinema.MoviePlaying(personMovies.Where(movie => movie.Title.ToLower() == inputMovie.ToLower()).FirstOrDefault());
            }
        }
    }
}
