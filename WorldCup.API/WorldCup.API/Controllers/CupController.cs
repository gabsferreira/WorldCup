using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WorldCup.API.Models;
using WorldCup.API.ViewModels;
using WorldCupAPI.Models;

namespace WorldCup.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CupController : ControllerBase
    {
        private readonly IMapper mapper;

        public CupController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post([FromBody] IEnumerable<MovieViewModel> moviesViewModel)
        {
            var movies = mapper.Map<IEnumerable<Movie>>(moviesViewModel).ToList();

            var cup = new Cup(movies);
            cup.Run();

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
