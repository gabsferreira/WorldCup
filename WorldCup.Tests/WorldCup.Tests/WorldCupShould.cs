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

            Assert.Matches(sut.Movies[0].Title, "Deadpool 2");
            Assert.Matches(sut.Movies[1].Title, "Han Solo: Uma História Star Wars");
            Assert.Matches(sut.Movies[2].Title, "Hereditário");
            Assert.Matches(sut.Movies[3].Title, "Jurassic World: Reino Ameaçado");
            Assert.Matches(sut.Movies[4].Title, "Oito Mulheres e um Segredo");
            Assert.Matches(sut.Movies[5].Title, "Os Incríveis 2");
            Assert.Matches(sut.Movies[6].Title, "Thor: Ragnarok");
            Assert.Matches(sut.Movies[7].Title, "Vingadores: Guerra Infinita");
        }

        [Fact]
        public void RunAndHaveRightMoviesForSemiFinal()
        {
            Cup sut = new Cup(MovieGenerator.GetDefaultMovieList());

            sut.Run();

            Assert.Matches(sut.FirstPhase.Winners[0].Title, "Vingadores: Guerra Infinita");
            Assert.Matches(sut.FirstPhase.Winners[1].Title, "Thor: Ragnarok");
            Assert.Matches(sut.FirstPhase.Winners[2].Title, "Os Incríveis 2");
            Assert.Matches(sut.FirstPhase.Winners[3].Title, "Jurassic World: Reino Ameaçado");
        }

        [Fact]
        public void RunAndHaveRightMoviesForFinal()
        {
            Cup sut = new Cup(MovieGenerator.GetDefaultMovieList());

            sut.Run();

            Assert.Matches(sut.SemiFinal.Winners[0].Title, "Vingadores: Guerra Infinita");
            Assert.Matches(sut.SemiFinal.Winners[1].Title, "Os Incríveis 2");
        }

        [Fact]
        public void RunAndHaveRightWinner()
        {
            Cup sut = new Cup(MovieGenerator.GetDefaultMovieList());

            sut.Run();

            Assert.Matches(sut.SemiFinal.Winners[0].Title, "Vingadores: Guerra Infinita");
        }
    }
}