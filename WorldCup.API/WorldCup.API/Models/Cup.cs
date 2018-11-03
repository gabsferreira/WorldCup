using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldCup.API.Models.Phases;
using WorldCupAPI.Models;

namespace WorldCup.API.Models
{
    public class Cup
    {
        public Guid Id { get; protected set; }
        public IReadOnlyList<Movie> Movies { get; set; }
        public Phase FirstPhase { get; protected set; }
        public Phase SemiFinal { get; protected set; }
        public Phase Final { get; protected set; }

        public Cup(List<Movie> movies)
        {
            Id = new Guid();
            this.Movies = movies.OrderBy(m => m.Title).ToList();

            this.FirstPhase = new FirstPhase(this.Movies);
        }

        public void Run()
        {
            this.FirstPhase.Run();

            this.SemiFinal = new Semifinal(this.FirstPhase.Winners);
            this.SemiFinal.Run();
        }
    }
}
