using CareBook.Application.Features.CQRS.Comments.CategoryCommands;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Handlers.CategoryHandlers
{
   public class CreateCategoryCommandsHandler
    {
        private readonly IRepository<Category> _repository;

        public CreateCategoryCommandsHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCategoryCommands command)
        {
            await _repository.CreateAsync(new Category
            {
                Name = command.Name
            });
        }
    }
}
