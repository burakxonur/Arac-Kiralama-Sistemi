using CareBook.Application.Features.CQRS.Queries.AboutQueries;
using CareBook.Application.Features.CQRS.Queries.BannerQueries;
using CareBook.Application.Features.CQRS.Results.AboutResults;
using CareBook.Application.Features.CQRS.Results.BannerResults;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Handlers.BannerHandlers
{
   public class GetBannerByIDQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerByIDQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task<GetBannerByIDQuerryResult> Handle(GetBannerByIDQuery query)
        {
            var values = await _repository.GetByIDAsync(query.ID);
            return new GetBannerByIDQuerryResult
            {
                BannerID = values.BannerID,
                Description = values.Description,
                Title = values.Title,
                VideoDescription = values.VideoDescription,
                VideoUrl=values.VideoUrl
            };
        }
    }
}
