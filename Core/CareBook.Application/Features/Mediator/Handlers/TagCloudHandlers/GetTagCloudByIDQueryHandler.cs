using CareBook.Application.Features.Mediator.Queries.TagCloudQueries;
using CareBook.Application.Features.Mediator.Results.TagCloudResults;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudByIDQueryHandler : IRequestHandler<GetTagCloudBYIDQuery, GetTagCloudByIDQueryResult>
    {
        private readonly IRepository<TagCloud> _repository;

        public GetTagCloudByIDQueryHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task<GetTagCloudByIDQueryResult> Handle(GetTagCloudBYIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIDAsync(request.ID);
            return new GetTagCloudByIDQueryResult
            {
                TagCloudID = values.TagCloudID,
                Title = values.Title,
                BlogID = values.BlogID
            };
        }
    }
}
