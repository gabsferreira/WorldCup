using System;
using System.Collections.Generic;
using System.Text;
using WorldCup.API.Exceptions;
using WorldCup.API.Models.Phases;
using Xunit;

namespace WorldCup.Tests
{
    public class FinalShould
    {
        [Fact]
        public void ThrowExceptionIfNumberOfMoviesIsWrong()
        {
            Assert.Throws<InvalidNumberOfMoviesException>(() => new Final(FakeMovieGenerator.GetDefaultMovieList()));
        }

        [Fact]
        public void HaveTheRightNumberOfMatchesAfterRun()
        {
            var final = new Final(FakeMovieGenerator.GetListWithTwoMovies());
            Assert.Equal(1, final.Matches.Count);
        }
    }
}
