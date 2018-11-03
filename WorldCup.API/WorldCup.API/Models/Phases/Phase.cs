using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCup.API.Models
{
    public abstract class Phase
    {
        protected IList<Match> Matches;
        public abstract void Run();

        public Phase()
        {
            this.Matches = new List<Match>();
        }
    }
}
