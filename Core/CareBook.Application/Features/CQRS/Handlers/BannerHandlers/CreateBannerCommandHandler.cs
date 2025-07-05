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
    public class CreateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public CreateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateBannerCommands command)
        {
            await _repository.CreateAsync(new Banner
            {
                Title=command.Title,
                Description=command.Description,
                VideoDescription=command.VideoDescription,
                VideoUrl=command.VideoUrl
            });
        }
    }
}
