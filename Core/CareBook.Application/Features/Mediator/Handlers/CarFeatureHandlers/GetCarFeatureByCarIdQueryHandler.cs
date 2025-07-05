
using CareBook.Application.Features.Mediator.Queries.CarFeatureQueries;
using CareBook.Application.Features.Mediator.Results.BlogResults;
using CareBook.Application.Features.Mediator.Results.CarFeatureResults;
using CareBook.Application.Features.Mediator.Results.LocationResults;
using CareBook.Application.İnterfaces;
using CareBook.Application.İnterfaces.BlogInterfaces;
using CareBook.Application.İnterfaces.CarFeatureInterfaces;
using CareBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class GetCarFeatureByCarIdQueryHandler : IRequestHandler<GetCarFeatureByCarIdQuery, List<GetCarFeatureByCarIdQueryResult>>
    {
        private readonly ICarFeatureRepository _repository;
        public GetCarFeatureByCarIdQueryHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCarFeatureByCarIdQueryResult>> Handle(GetCarFeatureByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarFeatureByCarID(request.ID);
            return values.Select(x => new GetCarFeatureByCarIdQueryResult
            {
                Available = x.Available,
                CarFeatureID = x.CarFeatureID,
                FeatureID = x.FeatureID,
                FeatureName = x.Feature.Name,
            }).ToList();
        }
    }
}
