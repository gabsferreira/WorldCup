using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldCup.API.Exceptions;
using WorldCup.API.Models.Phases;
using WorldCupAPI.Models;

namespace WorldCup.API.Models
{
    public class Cup
    {
        public Guid Id { get; private set; }
        public IReadOnlyList<Movie> Movies { get; }
        public Phase FirstPhase { get; private set; }
        public Phase SemiFinal { get; private set; }
        public Phase Final { get; private set; }

        public Movie Champion => Final.Winners.Single();
        public Movie SecondPlace => Final.Losers.Single();

        public Cup(IEnumerable<Movie> movies)
        {
            if (movies.Count() != 8)
                throw new InvalidNumberOfMoviesException();

            Id = Guid.NewGuid();
            this.Movies = movies.OrderBy(m => m.Title).ToList();

            this.FirstPhase = new FirstPhase(this.Movies);
        }

        public void Run()
        {
            this.FirstPhase.Run();

            this.SemiFinal = new Semifinal(this.FirstPhase.Winners);
            this.SemiFinal.Run();

            this.Final = new Final(this.SemiFinal.Winners);
            this.Final.Run();
        }
    }
}
