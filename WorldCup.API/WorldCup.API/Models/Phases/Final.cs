using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldCupAPI.Models;

namespace WorldCup.API.Models.Phases
{
    public class Final : Phase
    {
        private const int numberOfMatches = 1;

        public Final(IEnumerable<Movie> players)
        {
            MakeMatches(players);
        }

        protected override void MakeMatches(IEnumerable<Movie> players)
        {
            this.Matches.Add(new Match(players));
        }
    }
}
