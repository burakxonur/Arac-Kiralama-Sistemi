using CareBook.Application.Features.CQRS.Queries.BannerQueries;
using CareBook.Application.Features.CQRS.Queries.BrandQueries;
using CareBook.Application.Features.CQRS.Results.BannerResults;
using CareBook.Application.Features.CQRS.Results.BrandResults;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Handlers.BrandHandlers
{
   public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandByIdQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task<GetBrandByIDQueryResult> Handle(GetBrandByIDQuery query)
        {
            var values = await _repository.GetByIDAsync(query.ID);
            return new GetBrandByIDQueryResult
            {
                BrandID = values.BrandID,
                Name = values.Name
            };
        }
    }
}
