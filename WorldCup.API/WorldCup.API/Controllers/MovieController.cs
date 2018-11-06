using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WorldCup.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private const string URL = "https://copafilmes.azurewebsites.net/api/filmes";
        private readonly HttpClient httpClient;

        public MovieController(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IActionResult> Get()
        {
            var response = await httpClient.GetAsync(URL);

            if (!response.IsSuccessStatusCode)
                return NotFound();

            var result = await response.Content.ReadAsStringAsync();

            return Ok(result);
        }
    }
}