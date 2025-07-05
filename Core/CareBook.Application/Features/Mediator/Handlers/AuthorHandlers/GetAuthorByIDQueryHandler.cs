using CareBook.Application.Features.Mediator.Queries.AuthorQueries;
using CareBook.Application.Features.Mediator.Results.AuthorResults;
using CareBook.Application.Features.Mediator.Results.FeatureResults;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class GetAuthorByIDQueryHandler : IRequestHandler<GetAuthorByIDQuery, GetAuthorByIDQueryResult>
    {
        private readonly IRepository<Author> _repository;

        public GetAuthorByIDQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task<GetAuthorByIDQueryResult> Handle(GetAuthorByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIDAsync(request.ID);
            return new GetAuthorByIDQueryResult
            {
                AuthorID = values.AuthorID,
                Name = values.Name,
                ImageUrl = values.ImageUrl,
                Description = values.Description
            };
        }
    }
}
