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
    public class CreateBrandCommadHandler
    {
        private readonly IRepository<Brand> _repository;

        public CreateBrandCommadHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateBrandCommands command)
        {
            await _repository.CreateAsync(new Brand
            {
               Name=command.Name
            });
        }
    }
}
