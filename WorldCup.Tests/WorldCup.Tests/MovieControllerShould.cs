using Microsoft.AspNetCore.Mvc;
using Moq;
using Moq.Protected;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WorldCup.API.Controllers;
using Xunit;

namespace WorldCup.Tests
{
    public class MovieControllerShould
    {
        [Fact]
        public async Task ReturnOkIfRequestIsOk()
        {
            var handlerMock = MockGenerator.HttpMessageHandlerMock(HttpStatusCode.OK);

            var httpClient = new HttpClient(handlerMock.Object);

            var movieController = new MovieController(httpClient);

            var resultado = await movieController.Get();

            Assert.IsType<OkObjectResult>(resultado);
        }

        [Fact]
        public async Task ReturnNotFoundIfRequestIsNotfound()
        {
            var handlerMock = MockGenerator.HttpMessageHandlerMock(HttpStatusCode.NotFound);

            var httpClient = new HttpClient(handlerMock.Object);

            var movieController = new MovieController(httpClient);

            var resultado = await movieController.Get();

            Assert.IsType<NotFoundResult>(resultado);
        }
    }
}
