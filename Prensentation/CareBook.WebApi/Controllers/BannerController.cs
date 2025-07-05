using CareBook.Application.Features.CQRS.Comments.BannerCommads;
using CareBook.Application.Features.CQRS.Handlers.BannerHandlers;
using CareBook.Application.Features.CQRS.Queries.BannerQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerController : ControllerBase
    {
        private readonly GetBannerQueryHandler _getBannerQueryHandler;
        private readonly GetBannerByIDQueryHandler _getBannerByIDQueryHandler;
        private readonly CreateBannerCommandHandler _createBannerCommandHandler;
        private readonly UpdateBannerCommandHandler _updateBannerCommandHandler;
        private readonly RemoveBannerCommandHandler _removeBannerCommandHandler;

        public BannerController(GetBannerQueryHandler getBannerQueryHandler, GetBannerByIDQueryHandler getBannerByIDQueryHandler, CreateBannerCommandHandler createBannerCommandHandler, UpdateBannerCommandHandler updateBannerCommandHandler, RemoveBannerCommandHandler removeBannerCommandHandler)
        {
            _getBannerQueryHandler = getBannerQueryHandler;
            _getBannerByIDQueryHandler = getBannerByIDQueryHandler;
            _createBannerCommandHandler = createBannerCommandHandler;
            _updateBannerCommandHandler = updateBannerCommandHandler;
            _removeBannerCommandHandler = removeBannerCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> BannerList()
        {
            var values = await _getBannerQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBanner(int id)
        {
            var values = await _getBannerByIDQueryHandler.Handle(new GetBannerByIDQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerCommands command)
        {
            await _createBannerCommandHandler.Handle(command);
            return Ok("Banner Eklenmiştir.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBanner(int id)
        {
            await _removeBannerCommandHandler.Handle(new RemoveBannerCommands(id));
            return Ok("Banner Silinmiştir.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBanner(UpdateBannerCommands command)
        {
            await _updateBannerCommandHandler.Handle(command);
            return Ok("Banner Güncellenmiştir.");
        }
    }
}
