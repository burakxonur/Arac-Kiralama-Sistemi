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
    public class UpdateBrandCommandHandler
    {
        private readonly IRepository<Brand> _repository;

        public UpdateBrandCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateBrandCommands command)
        {
            var values = await _repository.GetByIDAsync(command.BrandID);
            values.Name = command.Name;
            await _repository.UpdatedAsync(values);
        }
    }
}
