using System;
using WorldCup.API.Models;
using WorldCupAPI.Models;
using Xunit;

namespace WorldCup.Tests
{
    public class WorldCupShould
    {
        [Fact]
        public void RunAndHaveTheRightMovieOrder()
        {
            Cup sut = new Cup(MovieGenerator.GetDefaultMovieList());

            sut.SortAlphabetically();

            Assert.Matches(sut.Movies[0].Title, "Deadpool 2");
            Assert.Matches(sut.Movies[1].Title, "Han Solo: Uma Hist�ria Star Wars");
            Assert.Matches(sut.Movies[2].Title, "Heredit�rio");
            Assert.Matches(sut.Movies[3].Title, "Jurassic World: Reino Amea�ado");
            Assert.Matches(sut.Movies[4].Title, "Oito Mulheres e um Segredo");
            Assert.Matches(sut.Movies[5].Title, "Os Incr�veis 2");
            Assert.Matches(sut.Movies[6].Title, "Thor: Ragnarok");
            Assert.Matches(sut.Movies[7].Title, "Vingadores: Guerra Infinita");
        }
    }
}