using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldCupAPI.Models;

namespace WorldCup.API.Models
{
    public class Cup
    {
        public Guid Id { get; set; }
        public IEnumerable<Movie> Filmes { get; }

        public Cup(IEnumerable<Movie> filmes)
        {
            Id = new Guid();
            this.Filmes = filmes;
        }
    }
}
