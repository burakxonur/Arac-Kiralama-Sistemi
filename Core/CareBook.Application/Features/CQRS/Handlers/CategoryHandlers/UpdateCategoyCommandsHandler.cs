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
  public  class UpdateCategoyCommandsHandler
    {
        private readonly IRepository<Category> _repository;

        public UpdateCategoyCommandsHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCategoryCommands command)
        {
            var values = await _repository.GetByIDAsync(command.CategoryID);
            values.Name = command.Name;
            await _repository.UpdatedAsync(values);
        }
    }
}
