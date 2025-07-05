using CareBook.Application.Features.Mediator.Queries.BlogQueries;
using CareBook.Application.Features.Mediator.Results.BlogResults;
using CareBook.Application.Features.Mediator.Results.LocationResults;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogBYIDQueryHandler : IRequestHandler<GetBlogByIDQueries, GetBlogByIDQueryResult>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogBYIDQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogByIDQueryResult> Handle(GetBlogByIDQueries request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIDAsync(request.ID);
            return new GetBlogByIDQueryResult
            {
                BlogID = values.BlogID,
                Title = values.Title,
                AuthorID=values.AuthorID,
                CategoryID=values.CategoryID,
                CoverImageUrl=values.CoverImageUrl,
                CreatedDate=values.CreatedDate,
                Description=values.Description
            };
        }
    }
}
