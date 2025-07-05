using CareBook.Application.Features.Mediator.Commands.BlogCommands;
using CareBook.Application.Features.Mediator.Queries.BlogQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            var values = await _mediator.Send(new GetBlogQueries());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlog(int id)
        {
            var values = await _mediator.Send(new GetBlogByIDQueries(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog Başarılı Bir Şekilde Eklendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveBlog(int id)
        {
            await _mediator.Send(new RemoveBlogCommand(id));
            return Ok("Blog Başarılı Bir Şekilde Silindi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog Başarılı Bir Şekilde Güncellendi.");
        }
        [HttpGet("GetLast3BlogWithAuthorsList")]
        public async Task<IActionResult> GetLast3BlogWithAuthorsList()
        {
            var values = await _mediator.Send(new GetLast3BlogWithAuthorsQuery());
            return Ok(values);
        }
        [HttpGet("GetAllBlogsWithAuthorList")]
        public async Task<IActionResult> GetAllBlogsWithAuthorList()
        {
            var values = await _mediator.Send(new GetAllBlogWithAuthorQueries());
            return Ok(values);
        }
        [HttpGet("GetBlogByAuthorID")]
        public async Task<IActionResult> GetBlogByAuthorID(int id)
        {
            var values = await _mediator.Send(new GetBlogByAuthorIDQuery(id));
            return Ok(values);
        }
    }
}
