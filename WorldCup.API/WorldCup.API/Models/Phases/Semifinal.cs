using System.Collections.Generic;
using System.Linq;
using WorldCup.API.Exceptions;
using WorldCupAPI.Models;

namespace WorldCup.API.Models.Phases
{
    public class SemiFinal : Phase
    {
        private const int numberOfMatches = 2;

        public SemiFinal(IEnumerable<Movie> movies) : base(movies)
        {
            if (movies.Count() != 4)
                throw new InvalidNumberOfMoviesException();

            MakeMatches(movies);
        }

        protected override void MakeMatches(IEnumerable<Movie> players)
        {
            Match firstMatch = new Match(players.Skip(0).Take(2).ToList());
            Match secondMatch = new Match(players.Skip(numberOfMatches).Take(2).ToList());

            this.Matches.Add(firstMatch);
            this.Matches.Add(secondMatch);
        }
    }
}
