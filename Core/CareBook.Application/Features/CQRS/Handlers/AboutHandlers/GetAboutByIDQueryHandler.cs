using CareBook.Application.Features.CQRS.Queries.AboutQueries;
using CareBook.Application.Features.CQRS.Results.AboutResults;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Handlers.AboutHandlers
{
   public class GetAboutByIDQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIDQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task<GetAboutByIDQueryResult> Handle(GetAboutByIDQuery query)
        {
            var values =await _repository.GetByIDAsync(query.ID);
            return new GetAboutByIDQueryResult
            {
                AboutID = values.AboutID,
                Description = values.Description,
                Title = values.Title,
                ImageUrl = values.ImageUrl
            };
        }
    }
}
