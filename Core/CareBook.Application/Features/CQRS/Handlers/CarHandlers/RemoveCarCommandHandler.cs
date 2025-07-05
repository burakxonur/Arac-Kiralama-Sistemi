using CareBook.Application.Features.CQRS.Comments.BrandCommands;
using CareBook.Application.Features.CQRS.Comments.CarCommands;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Handlers.CarHandlers
{
   public class RemoveCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public RemoveCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveCarCommands command)
        {
            var value = await _repository.GetByIDAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
