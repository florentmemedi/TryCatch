using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaLab.Enums;

namespace CinemaLab.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }

        public Movie(string title, Genre genre, int rating, double ticketprice)
        {
            Title = title;
            Genre = genre;
            try
            {
                if (rating > 0 && rating <= 5)
                {
                    Rating = rating;
                }
                else
                {
                    throw new Exception("Rating must be from 1 to 5");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            TicketPrice = Rating * 5;
        }
    }
}
