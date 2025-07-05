using CareBook.Application.Features.CQRS.Comments.BannerCommads;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Handlers.BannerHandlers
{
   public class RemoveBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public RemoveBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveBannerCommands command)
        {
            var value = await _repository.GetByIDAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
