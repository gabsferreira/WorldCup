using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WorldCup.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly HttpClient httpClient;

        public MovieController(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IActionResult> Get()
        {
            var response = await httpClient.GetAsync("https://copafilmes.azurewebsites.net/api/filmes");

            if (!response.IsSuccessStatusCode)
                return NotFound();

            var result = await response.Content.ReadAsStringAsync();

            return Ok(result);
        }
    }
}