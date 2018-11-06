using System;
using System.Collections.Generic;
using System.Text;
using WorldCup.API.Exceptions;
using WorldCup.API.Models.Phases;
using Xunit;

namespace WorldCup.Tests
{
    public class FirstPhaseShould
    {
        [Fact]
        public void ThrowExceptionIfNumberOfMoviesIsWrong()
        {
            Assert.Throws<InvalidNumberOfMoviesException>(() => new FirstPhase(FakeMovieGenerator.GetListWithTwoMovies()));
        }

        [Fact]
        public void HaveTheRightNumberOfMatchesAfterRun()
        {
            var firstPhase = new FirstPhase(FakeMovieGenerator.GetDefaultMovieList());
            Assert.Equal(4, firstPhase.Matches.Count);
        }
    }
}
