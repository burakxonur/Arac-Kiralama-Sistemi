using CareBook.Dto.AuthorDto;
using CareBook.Dto.StatisticsDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CareBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistics")]
    public class AdminStatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdminStatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("Index")]
        public async Task<IActionResult> Index()
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

            var responseMessage3 = await client.GetAsync("https://localhost:7120/api/Statistics/GetAuthorCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                int v3 = random.Next(0, 101);
                var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                var values3 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData3);
                ViewBag.TplAuthorCount = values3.AuthorCount;
                ViewBag.TplAuthorProgres = v3;
            }

            var responseMessage4 = await client.GetAsync("https://localhost:7120/api/Statistics/GetBlogCount");
            if (responseMessage4.IsSuccessStatusCode)
            {
                int v4 = random.Next(0, 101);
                var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
                var values4 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData4);
                ViewBag.TplBlogCount = values4.BlogCount;
                ViewBag.TplBlogProgres = v4;
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

            var responseMessage7 = await client.GetAsync("https://localhost:7120/api/Statistics/GetAvgRentPriceForWeekly");
            if (responseMessage7.IsSuccessStatusCode)
            {
                int v7 = random.Next(0, 101);
                var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
                var values7 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData7);
                ViewBag.TplAvgRentPriceForWeeklyCount = values7.getAvgRentPriceForWeekly.ToString("0,00");
                ViewBag.TplAvgRentPriceForWeeklyProgres = v7;
            }

            var responseMessage8 = await client.GetAsync("https://localhost:7120/api/Statistics/GetCarCountByTransmissionIsAuto");
            if (responseMessage8.IsSuccessStatusCode)
            {
                int v8 = random.Next(0, 101);
                var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
                var values8 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData8);
                ViewBag.TplCarCountByTransmissionIsAutoCount = values8.CarCountByTransmissionIsAuto;
                ViewBag.TplCarCountByTransmissionIsAutoProgres = v8;
            }

            var responseMessage9 = await client.GetAsync("https://localhost:7120/api/Statistics/BrandNameByMaxCar");
            if (responseMessage9.IsSuccessStatusCode)
            {
                int v9 = random.Next(0, 101);
                var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
                var values9 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData9);
                ViewBag.TplBrandNameByMaxCarCount = values9.BrandNameByMaxCar;
                ViewBag.TplBrandNameByMaxCarProgres = v9;
            }

            var responseMessage10 = await client.GetAsync("https://localhost:7120/api/Statistics/BlogTitleByMaxBlogComment");
            if (responseMessage10.IsSuccessStatusCode)
            {
                int v10 = random.Next(0, 101);
                var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
                var values10 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData10);
                ViewBag.TplBlogTitleByMaxBlogCommentCount = values10.blogTitleByMaxBlogComment;
                ViewBag.TplBlogTitleByMaxBlogCommentProgres = v10;
            }

            var responseMessage11 = await client.GetAsync("https://localhost:7120/api/Statistics/GetCarCountByKmSmallerThen1000");
            if (responseMessage11.IsSuccessStatusCode)
            {
                int v11 = random.Next(0, 101);
                var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
                var values11 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData11);
                ViewBag.TplcarCountByKmSmallerThen1000Count = values11.carCountByKmSmallerThen1000;
                ViewBag.TplcarCountByKmSmallerThen1000Progres = v11;
            }

            var responseMessage12 = await client.GetAsync("https://localhost:7120/api/Statistics/GetCarCountByFuelGasolineOrDiesel");
            if (responseMessage12.IsSuccessStatusCode)
            {
                int v12 = random.Next(0, 101);
                var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
                var values12 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData12);
                ViewBag.TplcarCountByFuelGasolineOrDieselCount = values12.carCountByFuelGasolineOrDiesel;
                ViewBag.TplcarCountByFuelGasolineOrDieselProgres = v12;
            }

            var responseMessage13 = await client.GetAsync("https://localhost:7120/api/Statistics/GetCarCountByFuelElectric");
            if (responseMessage13.IsSuccessStatusCode)
            {
                int v13 = random.Next(0, 101);
                var jsonData13 = await responseMessage13.Content.ReadAsStringAsync();
                var values13 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData13);
                ViewBag.TplcarCountByFuelElectricCount = values13.carCountByFuelElectric;
                ViewBag.TplcarCountByFuelElectricProgres = v13;
            }

            var responseMessage14 = await client.GetAsync("https://localhost:7120/api/Statistics/GetCarBrandandModelByRentPriceDailyMax");
            if (responseMessage14.IsSuccessStatusCode)
            {
                int v14 = random.Next(0, 101);
                var jsonData14 = await responseMessage14.Content.ReadAsStringAsync();
                var values14 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData14);
                ViewBag.TplgetCarBrandandModelByRentPriceDailyMaxMyPropertyCount = values14.getCarBrandandModelByRentPriceDailyMaxMyProperty;
                ViewBag.TplgetCarBrandandModelByRentPriceDailyMaxMyPropertyProgres = v14;
            }

            var responseMessage15 = await client.GetAsync("https://localhost:7120/api/Statistics/GetCarBrandandModelByRentPriceDailyMin");
            if (responseMessage15.IsSuccessStatusCode)
            {
                int v15 = random.Next(0, 101);
                var jsonData15 = await responseMessage15.Content.ReadAsStringAsync();
                var values15 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData15);
                ViewBag.TplgetCarBrandandModelByRentPriceDailyMinCount = values15.getCarBrandandModelByRentPriceDailyMin;
                ViewBag.TplgetCarBrandandModelByRentPriceDailyMinProgres = v15;
            }

            var responseMessage16 = await client.GetAsync("https://localhost:7120/api/Statistics/GetAvgRentPriceForMountly");
            if (responseMessage16.IsSuccessStatusCode)
            {
                int v16 = random.Next(0, 101);
                var jsonData16 = await responseMessage16.Content.ReadAsStringAsync();
                var values16 = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData16);
                ViewBag.TplavgRentPriceForMountlyCount = values16.avgRentPriceForMountly.ToString("0,00");
                ViewBag.TplavgRentPriceForMountlyProgres = v16;
            }


            return View();
        }
    }
}
