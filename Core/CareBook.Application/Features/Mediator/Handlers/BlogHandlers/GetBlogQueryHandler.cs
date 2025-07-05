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
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQueries, List<GetBlogQueryResult>>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogQueryResult>> Handle(GetBlogQueries request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBlogQueryResult
            {
                BlogID = x.BlogID,
                Title = x.Title,
                AuthorID = x.AuthorID,
                CategoryID = x.CategoryID,
                Description = x.Description,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
            }).ToList();
        }
    }
}
