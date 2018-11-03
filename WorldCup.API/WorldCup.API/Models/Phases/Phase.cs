using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldCupAPI.Models;

namespace WorldCup.API.Models
{
    public abstract class Phase
    {
        public IList<Match> Matches;
        public IList<Movie> Winners { get; protected set; }
        public IList<Movie> Losers { get; protected set; }

        public Phase()
        {
            this.Matches = new List<Match>();
            this.Winners = new List<Movie>();
            this.Losers = new List<Movie>();
        }

        public virtual void Run()
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
