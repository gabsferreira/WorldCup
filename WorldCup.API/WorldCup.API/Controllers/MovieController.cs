using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WorldCup.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public async Task<IActionResult> Get()
        {
            HttpClient httpClient = new HttpClient();

            var responseMessage = await httpClient.GetAsync("https://copafilmes.azurewebsites.net/api/filmes");

            if (!responseMessage.IsSuccessStatusCode) return null;

            var jsonResult = await responseMessage.Content.ReadAsStringAsync();

            return Ok(jsonResult);
        }
    }
}