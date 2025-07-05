using CareBook.Dto.FooterAddressDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CareBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminFooter")]

    public class AdminFooterAddreesController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminFooterAddreesController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7120/api/FooterAddress");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFooterAddressDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        [Route("CreateFooter")]
        public IActionResult CreateFooter()
        {
            return View();
        }
        [HttpPost]
        [Route("CreateFooter")]
        public async Task<IActionResult> CreateFooter(CreateFooterAddressDto createFooterDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createFooterDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7120/api/FooterAddress/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminFooter", new { area = "Admin" });
            }
            return View();
        }
        [Route("DeleteFooter/{id}")]
        public async Task<IActionResult> DeleteFooter(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync("https://localhost:7120/api/FooterAddress?id=" + id);

            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Footer başarıyla silindi.";
            }
            else
            {
                TempData["ErrorMessage"] = "Silme işlemi başarısız oldu.";
            }

            return RedirectToAction("Index", "AdminFooter", new { area = "Admin" });
        }
        [HttpGet]
        [Route("UpdateFooter    /{id}")]
        public async Task<IActionResult> UpdateFooter(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync($"https://localhost:7120/api/FooterAddress/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateFooterAddreesDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        [Route("UpdateFooter/{id}")]
        public async Task<IActionResult> UpdateFooter(UpdateFooterAddreesDto updateFooterDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateFooterDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7120/api/FooterAddress/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminFooter", new { area = "Admin" });
            }
            return View();
        }
    }
}
