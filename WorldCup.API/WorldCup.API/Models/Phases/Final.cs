using System.Collections.Generic;
using WorldCupAPI.Models;

namespace WorldCup.API.Models.Phases
{
    public class Final : Phase
    {
        public Final(IEnumerable<Movie> players) : base(players) { }

        protected override void MakeMatches(IEnumerable<Movie> players) => this.Matches.Add(new Match(players));
    }
}
