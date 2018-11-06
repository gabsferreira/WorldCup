using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WorldCup.API.Models;
using WorldCup.API.Repositories;
using WorldCup.API.ViewModels;
using WorldCupAPI.Models;

namespace WorldCup.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CupController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IRepository<Cup> repository;

        public CupController(IMapper mapper, IRepository<Cup> repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        [HttpPost]
        public IActionResult Post([FromBody] IEnumerable<MovieViewModel> moviesViewModel)
        {
            var movies = mapper.Map<IEnumerable<Movie>>(moviesViewModel).ToList();

            var cup = new Cup(movies);
            cup.Run();
            repository.Save(cup);

            return CreatedAtRoute("Get", new { id = cup.Id }, cup);
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get([FromRoute] string id)
        {
            string teste = id;

            return Ok();
        }
    }
}
