using CareBook.Application.Features.CQRS.Queries.CategoryQueries;
using CareBook.Application.Features.CQRS.Results.CategoryResults;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Handlers.CategoryHandlers
{
  public  class GetCategoryByIDQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryByIDQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task<GetCategoryByIDQueryResult> Handle(GetCategoryByIDQuery query)
        {
            var values = await _repository.GetByIDAsync(query.ID);
            return new GetCategoryByIDQueryResult
            {
                CategoryID = values.CategoryID,
                Name = values.Name
            };
        }
    }
}
