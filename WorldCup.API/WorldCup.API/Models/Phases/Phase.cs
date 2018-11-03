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

        public abstract void Run();

        public Phase()
        {
            this.Matches = new List<Match>();
            this.Winners = new List<Movie>();
            this.Losers = new List<Movie>();
        }
    }
}
