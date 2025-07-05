using CareBook.Application.Features.CQRS.Results.CarResults;
using CareBook.Application.Features.Mediator.Queries.BlogQueries;
using CareBook.Application.Features.Mediator.Results.BlogResults;
using CareBook.Application.İnterfaces;
using CareBook.Application.İnterfaces.BlogInterfaces;
using CareBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetLat3BlogWithAuthorsQueryHandlers : IRequestHandler<GetLast3BlogWithAuthorsQuery, List<GetLast3BlogWithAuthorsQueryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetLat3BlogWithAuthorsQueryHandlers(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLast3BlogWithAuthorsQueryResult>> Handle(GetLast3BlogWithAuthorsQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetLat3BlogWithAuthor();
            return values.Select(x => new GetLast3BlogWithAuthorsQueryResult
            {
                AuthorID = x.AuthorID,
                BlogID = x.BlogID,
                CategoryID = x.CategoryID,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Title = x.Title,
                Description = x.Description,
                AuthorName = x.Author.Name
            }).ToList();
        }
    }
}
