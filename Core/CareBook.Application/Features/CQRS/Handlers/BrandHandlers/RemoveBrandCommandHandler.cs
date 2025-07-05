using CareBook.Application.Features.CQRS.Comments.BannerCommads;
using CareBook.Application.Features.CQRS.Comments.BrandCommands;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Handlers.BrandHandlers
{
  public  class RemoveBrandCommandHandler
    {
        private readonly IRepository<Brand> _repository;

        public RemoveBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveBrandCommands command)
        {
            var value = await _repository.GetByIDAsync(command.ID);
            await _repository.RemoveAsync(value);
        }
    }
}
