using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCupAPI.Models
{
    public class Movie
    {
        public Guid Id { get; protected set; }
        public string Title { get; protected set; }
        public int Year { get; protected set; }
        public double Rating { get; protected set; }

        public Movie() { }

        public Movie(Guid id, string title, int year, double rating)
        {
            this.Id = id;
            this.Title = title;
            this.Year = year;
            this.Rating = rating;
        }
    }
}



