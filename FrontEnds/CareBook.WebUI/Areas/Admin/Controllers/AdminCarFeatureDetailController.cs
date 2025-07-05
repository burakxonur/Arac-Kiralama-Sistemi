using CareBook.Dto.CarFeatureDtos;
using CareBook.Dto.CategoryDto;
using CareBook.Dto.FeatureDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CareBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminCarFeatureDetail")]
    public class AdminCarFeatureDetailController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminCarFeatureDetailController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet("Index/{id}")]
        public async Task<IActionResult> Index(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7120/api/CarFeatures?id=" + id);

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarFeatureByCarIDDto>>(jsonData);
                ViewBag.CarID = id; // POST için gerekli
                return View(values);
            }

            return View();
        }

        [HttpPost("Index/{id}")]
        public async Task<IActionResult> Index(int id, List<ResultCarFeatureByCarIDDto> resultCarFeatureByCarIdDto)
        {
            if (resultCarFeatureByCarIdDto == null || !resultCarFeatureByCarIdDto.Any())
            {
                TempData["Error"] = "Formdan veri alınamadı.";
                return RedirectToAction("Index", new { id });
            }

            foreach (var item in resultCarFeatureByCarIdDto)
            {
                var client = _httpClientFactory.CreateClient();
                string url = item.Available
                    ? $"https://localhost:7120/api/CarFeatures/CarFeatureChangeAvailableToTrue?id={item.CarFeatureID}"
                    : $"https://localhost:7120/api/CarFeatures/CarFeatureChangeAvailableToFalse?id={item.CarFeatureID}";

                var response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"API Hatası: {response.StatusCode}");
                }
            }

            return RedirectToAction("Index", "AdminCar");
        }
        [Route("CreateFeatureByCarId")]
        [HttpGet]
        public async Task<IActionResult> CreateFeatureByCarId()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7120/api/Features");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFeatureDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }

}