using System.Collections.Generic;
using WorldCup.API.Exceptions;
using WorldCupAPI.Models;
using System.Linq;

namespace WorldCup.API.Models.Phases
{
    public class Final : Phase
    {
        public Final(IEnumerable<Movie> movies) : base(movies)
        {
            if (movies.Count() != 2)
                throw new InvalidNumberOfMoviesException();

            MakeMatches(movies);
        }

        protected override void MakeMatches(IEnumerable<Movie> players) => this.Matches.Add(new Match(players));
    }
}
