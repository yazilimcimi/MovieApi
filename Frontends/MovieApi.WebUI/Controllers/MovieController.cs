using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Dto.Dtos;
using MovieApi.Dto.Dtos.MovieDtos;
using Newtonsoft.Json;

namespace MovieApi.WebUI.Controllers
{
    public class MovieController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MovieController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> MovieList()
        {
            ViewBag.v1 = "Film Listesi";
            ViewBag.v2 = "AnaSayfa";
            ViewBag.v3 = "Tüm mler";

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7288/api/movies");
            //var responseMessage = await client.GetAsync("http://localhost:5190/api/movies");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultMovieDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> MovieDetail(int id)
        {
            id = 0;
            return View();
        }
    }
}
