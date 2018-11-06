using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldCup.API.Models;

namespace WorldCup.API.Repositories
{
    public class CupRepository : IRepository<Cup>
    {
        private static readonly IList<Cup> cups = new List<Cup>();

        public Cup GetById(Guid id)
        {
            return cups.FirstOrDefault(c => c.Id == id);
        }

        public void Save(Cup cup)
        {
            cups.Add(cup);
        }
    }
}
