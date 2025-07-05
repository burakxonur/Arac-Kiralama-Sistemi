using CareBook.Application.Features.RepositoryPattern;
using CareBook.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IGenericRepository<Comment> _commentrepository;

        public CommentController(IGenericRepository<Comment> commentrepository)
        {
            _commentrepository = commentrepository;
        }
        [HttpGet]
        public IActionResult CommentList()
        {
            var values = _commentrepository.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateComment(Comment comment)
        {
            _commentrepository.Create(comment);
            return Ok("Yorum Başarıyla Eklendi.");
        }
        [HttpDelete]
        public IActionResult RemoveComment(int id)
        {
           var value= _commentrepository.GetById(id);
            _commentrepository.Remove(value);
            return Ok("Yorum Başarıyla Silindi.");
        }
        [HttpPut]
        public IActionResult UpdateComment(Comment comment)
        {
            _commentrepository.Update(comment);
            return Ok("Yorum Başarıyla Güncllendi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetComment(int id)
        {
            var values = _commentrepository.GetById(id);
            return Ok(values);
        }
        [HttpGet("CommentListByBlog")]
        public IActionResult CommentListByBlog(int id)
        {
            var values = _commentrepository.GetCommentsByBlogId(id);
            return Ok(values);
        }
    }
}
