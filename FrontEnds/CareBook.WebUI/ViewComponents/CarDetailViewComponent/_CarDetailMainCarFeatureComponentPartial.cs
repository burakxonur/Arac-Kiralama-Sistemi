﻿using CareBook.Dto.CarDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CareBook.WebUI.ViewComponents.CarDetailViewComponent
{
    public class _CarDetailMainCarFeatureComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _CarDetailMainCarFeatureComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.CarId = id;
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync($"https://localhost:7120/api/Cars/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultCarWithBrandsDto>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
