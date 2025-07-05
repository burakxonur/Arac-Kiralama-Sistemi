using CareBook.Application.Features.Mediator.Queries.TagCloudQueries;
using CareBook.Application.Features.Mediator.Results.TagCloudResults;
using CareBook.Application.İnterfaces.TagCloudInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudBYBlogIDQueryHandler : IRequestHandler<GetTagCloudBYBlogIDQuery, List<GetTagCloudBlogIDQueryResult>>
    {
        private readonly ITagCloudRepository _repository;

        public GetTagCloudBYBlogIDQueryHandler(ITagCloudRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTagCloudBlogIDQueryResult>> Handle(GetTagCloudBYBlogIDQuery request, CancellationToken cancellationToken)
        {
            var values =  _repository.GetTagCloudsByBlogID(request.ID);
            return values.Select(x => new GetTagCloudBlogIDQueryResult
            {
                TagCloudID = x.TagCloudID,
                Title = x.Title,
                BlogID = x.BlogID
            }).ToList();
        }
    }
}
