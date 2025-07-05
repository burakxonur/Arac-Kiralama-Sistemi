using CareBook.Dto.StatisticsDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CareBook.WebUI.ViewComponents.DashboardComponents
{
    public class _AdminDashboardStatisticsComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AdminDashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Random random = new Random();
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("https://localhost:7120/api/Statistics/GetCarCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                int v1 = random.Next(0, 101);
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.TplCarCount = values.CarCount;
                ViewBag.TplCarProgres = v1;
            }

            var responseMessage2 = await client.GetAsync("https://localhost:7120/api/Statistics/GetLocationCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                int v2 = random.Next(0, 101);
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData2);
                ViewBag.TplLocationCount = values2.LocationCount;
                ViewBag.TplLocationProgres = v2;
            }

            var responseMessage5 = await client.GetAsync("https://localhost:7120/api/Statistics/GetBrandCount");
            if (responseMessage5.IsSuccessStatusCode)
            {
                int v5 = random.Next(0, 101);
                var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
                var values5 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData5);
                ViewBag.TplBrandCount = values5.BrandCount;
                ViewBag.TplBrandProgres = v5;
            }   

            var responseMessage6 = await client.GetAsync("https://localhost:7120/api/Statistics/GetAvgRentPriceForDay");
            if (responseMessage6.IsSuccessStatusCode)
            {
                int v6 = random.Next(0, 101);
                var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
                var values6 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData6);
                ViewBag.TplAvgRentPriceForDayCount = values6.AvgRentPriceForDay.ToString("0,00");
                ViewBag.TplAvgRentPriceForDayProgres = v6;
            }

            return View();
        }
    }
}
