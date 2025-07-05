using CareBook.Application.Features.Mediator.Queries.LocationQueries;
using CareBook.Application.Features.Mediator.Results.FeatureResults;
using CareBook.Application.Features.Mediator.Results.LocationResults;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class GetTagCloudByIDQueryHandler : IRequestHandler<GetLocationByIDQuery, GetLocationByIDQueryResult>
    {
        private readonly IRepository<Location> _repository;

        public GetTagCloudByIDQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<GetLocationByIDQueryResult> Handle(GetLocationByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIDAsync(request.ID);
            return new GetLocationByIDQueryResult
            {
                LocationID = values.LocationID,
                Name = values.Name
            };
        }
    }
}
