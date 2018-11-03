using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCup.API.Models
{
    public abstract class Phase
    {
        private IEnumerable<Match> Matches;
        public abstract void Run();
    }
}
