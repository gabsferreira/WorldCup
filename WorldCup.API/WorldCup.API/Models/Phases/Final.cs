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

        private void MakeMatches(IEnumerable<Movie> players)
        {
            this.Matches.Add(new Match(players));
        }

        public override void Run()
        {
            foreach (var match in this.Matches)
            {
                match.Play();
                this.Winners.Add(match.Winner);
                this.Losers.Add(match.Loser);
            }
        }
    }
}
