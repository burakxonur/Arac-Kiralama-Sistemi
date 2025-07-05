using CareBook.Application.Features.Mediator.Queries.StatisticsQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StatisticsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetCarCount")]
        public async Task<IActionResult> GetCarCount()
        {
            var values = await _mediator.Send(new GetCarCountQuery());
            return Ok(values);
        }
        [HttpGet("GetLocationCount")]
        public async Task<IActionResult> GetLocationCount()
        {
            var values = await _mediator.Send(new GetLocationCountQuery());
            return Ok(values);
        }
        [HttpGet("GetAuthorCount")]
        public async Task<IActionResult> GetAuthorCount()
        {
            var values = await _mediator.Send(new GetAuthorCountQuery());
            return Ok(values);
        }
        [HttpGet("GetBlogCount")]
        public async Task<IActionResult> GetBlogCount()
        {
            var values = await _mediator.Send(new GetBlogCountQuery());
            return Ok(values);
        }
        [HttpGet("GetBrandCount")]
        public async Task<IActionResult> GetBrandCount()
        {
            var values = await _mediator.Send(new GetBrandCountQuery());
            return Ok(values);
        }
        [HttpGet("GetAvgRentPriceForDay")]
        public async Task<IActionResult> GetAvgRentPriceForDay()
        {
            var values = await _mediator.Send(new GetAvgRentPriceForDayQuery());
            return Ok(values);
        }
        [HttpGet("GetAvgRentPriceForWeekly")]
        public async Task<IActionResult> GetAvgRentPriceForWeekly()
        {
            var values = await _mediator.Send(new GetAvgRentPriceForWeeklyQuery());
            return Ok(values);
        }
        [HttpGet("GetAvgRentPriceForMountly")]
        public async Task<IActionResult> GetAvgRentPriceForMountly()
        {
            var values = await _mediator.Send(new GetAvgRentPriceForMountlyQuery());
            return Ok(values);
        }
        [HttpGet("GetCarCountByTransmissionIsAuto")]
        public async Task<IActionResult> GetCarCountByTransmissionIsAuto()
        {
            var values = await _mediator.Send(new GetCarCountByTransmissionIsAutoQuery());
            return Ok(values);
        }
        [HttpGet("BrandNameByMaxCar")]
        public async Task<IActionResult> BrandNameByMaxCar()
        {
            var values = await _mediator.Send(new BrandNameByMaxCarQuery());
            return Ok(values);
        }
        [HttpGet("BlogTitleByMaxBlogComment")]
        public async Task<IActionResult> BlogTitleByMaxBlogComment()
        {
            var values = await _mediator.Send(new BlogTitleByMaxBlogCommentQuery());
            return Ok(values);
        }
        [HttpGet("GetCarCountByKmSmallerThen1000")]
        public async Task<IActionResult> GetCarCountByKmSmallerThen1000()
        {
            var values = await _mediator.Send(new GetCarCountByKmSmallerThen1000Query());
            return Ok(values);
        }
        [HttpGet("GetCarCountByFuelGasolineOrDiesel")]
        public async Task<IActionResult> GetCarCountByFuelGasolineOrDiesel()
        {
            var values = await _mediator.Send(new GetCarCountByFuelGasolineOrDieselQuery());
            return Ok(values);
        }
        [HttpGet("GetCarCountByFuelElectric")]
        public async Task<IActionResult> GetCarCountByFuelElectric()
        {
            var values = await _mediator.Send(new GetCarCountByFuelElectricQuery());
            return Ok(values);
        }
        [HttpGet("GetCarBrandandModelByRentPriceDailyMax")]
        public async Task<IActionResult> GetCarBrandandModelByRentPriceDailyMax()
        {
            var values = await _mediator.Send(new GetCarBrandandModelByRentPriceDailyMaxQuery());
            return Ok(values);
        }
        [HttpGet("GetCarBrandandModelByRentPriceDailyMin")]
        public async Task<IActionResult> GetCarBrandandModelByRentPriceDailyMin()
        {
            var values = await _mediator.Send(new GetCarBrandandModelByRentPriceDailyMinQuery());
            return Ok(values);
        }
    }
}
