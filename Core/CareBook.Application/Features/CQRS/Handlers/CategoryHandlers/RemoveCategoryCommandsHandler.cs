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
   public class RemoveCategoryCommandsHandler
    {
        private readonly IRepository<Category> _repository;

        public RemoveCategoryCommandsHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveCategoryCommands command)
        {
            var value = await _repository.GetByIDAsync(command.ID);
            await _repository.RemoveAsync(value);
        }
    }
}
