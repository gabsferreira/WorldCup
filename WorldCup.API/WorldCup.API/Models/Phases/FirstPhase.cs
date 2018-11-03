using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldCupAPI.Models;

namespace WorldCup.API.Models.Phases
{
    public class FirstPhase : Phase
    {
        private const int numberOfMatches = 4;

        public FirstPhase(IEnumerable<Movie> players)
        {
            MakeMatches(players);
            this.Winners = new List<Movie>();
        }

        private void MakeMatches(IEnumerable<Movie> players)
        {
            for (int i = 0; i < numberOfMatches; i++)
            {
                var firstPlayer = players.Skip(i).Take(1).First();
                var secondPlayer = players.Skip(players.Count() - i - 1).Take(1).First();

                Match match = new Match(new List<Movie> { firstPlayer, secondPlayer });

                this.Matches.Add(match);
            }    
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
