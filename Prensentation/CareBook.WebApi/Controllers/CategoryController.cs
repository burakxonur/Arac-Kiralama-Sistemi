using CareBook.Application.Features.CQRS.Comments.CategoryCommands;
using CareBook.Application.Features.CQRS.Comments.CategoryCommands;
using CareBook.Application.Features.CQRS.Handlers.CategoryHandlers;
using CareBook.Application.Features.CQRS.Handlers.CategoryHandlers;
using CareBook.Application.Features.CQRS.Queries.CategoryQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CreateCategoryCommandsHandler _createCategoryCommadHandler;
        private readonly GetCategoryByIDQueryHandler _getCategoryByIdQueryHandler;
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
        private readonly UpdateCategoyCommandsHandler _updateCategoryCommandHandler;
        private readonly RemoveCategoryCommandsHandler _removeCategoryCommandHandler;

        public CategoryController(CreateCategoryCommandsHandler createCategoryCommadHandler, GetCategoryByIDQueryHandler getCategoryByIdQueryHandler, GetCategoryQueryHandler getCategoryQueryHandler, UpdateCategoyCommandsHandler updateCategoryCommandHandler, RemoveCategoryCommandsHandler removeCategoryCommandHandler)
        {
            _createCategoryCommadHandler = createCategoryCommadHandler;
            _getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
            _getCategoryQueryHandler = getCategoryQueryHandler;
            _updateCategoryCommandHandler = updateCategoryCommandHandler;
            _removeCategoryCommandHandler = removeCategoryCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _getCategoryQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var values = await _getCategoryByIdQueryHandler.Handle(new GetCategoryByIDQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommands command)
        {
            await _createCategoryCommadHandler.Handle(command);
            return Ok("Kategori Bilgisi Eklenmiştir.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _removeCategoryCommandHandler.Handle(new RemoveCategoryCommands(id));
            return Ok("Kategori Bilgisi Silinmiştir.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommands command)
        {
            await _updateCategoryCommandHandler.Handle(command);
            return Ok("Kategori Bilgisi Güncellenmiştir.");
        }
    }
}
