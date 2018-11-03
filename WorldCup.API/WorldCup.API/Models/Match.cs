using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldCupAPI.Models;

namespace WorldCup.API.Models
{
    public class Match
    {
        public Movie Winner { get; protected set; }
        public Movie Loser { get; protected set; }
        private IEnumerable<Movie> Players;

        public Match(IEnumerable<Movie> players)
        {
            this.Players = players;
        }

        public void Play()
        {
            this.Players = this.Players
                .OrderByDescending(p => p.Rating)
                .ThenBy(p => p.Title)
                .ToList();

            this.Winner = this.Players.First();
            this.Loser = this.Players.Last();
        }
    }
}
