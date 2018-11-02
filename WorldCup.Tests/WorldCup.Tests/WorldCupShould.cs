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
            Assert.Matches(sut.Movies[1].Title, "Han Solo: Uma História Star Wars");
            Assert.Matches(sut.Movies[2].Title, "Hereditário");
            Assert.Matches(sut.Movies[3].Title, "Jurassic World: Reino Ameaçado");
            Assert.Matches(sut.Movies[4].Title, "Oito Mulheres e um Segredo");
            Assert.Matches(sut.Movies[5].Title, "Os Incríveis 2");
            Assert.Matches(sut.Movies[6].Title, "Thor: Ragnarok");
            Assert.Matches(sut.Movies[7].Title, "Vingadores: Guerra Infinita");
        }
    }
}