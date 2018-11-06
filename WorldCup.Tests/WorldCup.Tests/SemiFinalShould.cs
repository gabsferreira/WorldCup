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
    }
}
