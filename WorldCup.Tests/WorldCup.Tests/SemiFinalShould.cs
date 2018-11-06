using System;
using System.Collections.Generic;
using System.Text;
using WorldCup.API.Exceptions;
using WorldCup.API.Models.Phases;
using Xunit;

namespace WorldCup.Tests
{
    public class SemiFinalShould
    {
        [Fact]
        public void ThrowExceptionIfNumberOfMoviesIsWrong()
        {
            Assert.Throws<InvalidNumberOfMoviesException>(() => new SemiFinal(FakeMovieGenerator.GetListWithTwoMovies()));
        }

        [Fact]
        public void HaveTheRightNumberOfMatchesAfterRun()
        {
            var semiFinal = new SemiFinal(FakeMovieGenerator.GetListWithFourMovies());
            Assert.Equal(2, semiFinal.Matches.Count);
        }
    }
}
