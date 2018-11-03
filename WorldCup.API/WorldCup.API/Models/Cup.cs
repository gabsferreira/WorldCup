using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldCupAPI.Models;

namespace WorldCup.API.Models
{
    public class Cup
    {
        public Guid Id { get; set; }
        public IReadOnlyList<Movie> Movies { get; set; }
        public Phase FirstPhase { get; protected set; }
        public Phase SemiFinal { get; protected set; }
        public Phase Final { get; protected set; }

        public Cup(List<Movie> movies)
        {
            Id = new Guid();
            this.Movies = movies;
        }

        public void SortAlphabetically()
        {
            this.Movies = this.Movies.OrderBy(m => m.Title).ToList();
        }

        public void Run()
        {
            
        }
    }
}
