using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldCupAPI.Models;

namespace WorldCup.API.Models.Phases
{
    public class Semifinal : Phase
    {
        private const int numberOfMatches = 2;

        public Semifinal(IEnumerable<Movie> players)
        {
            MakeMatches(players);
            this.Winners = new List<Movie>();
        }

        private void MakeMatches(IEnumerable<Movie> players)
        {
            Match firstMatch = new Match(players.Skip(0).Take(2).ToList());
            Match secondMatch = new Match(players.Skip(numberOfMatches).Take(2).ToList());

            this.Matches.Add(firstMatch);
            this.Matches.Add(secondMatch);
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
