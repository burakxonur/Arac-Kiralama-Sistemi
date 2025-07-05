using CareBook.Application.Features.CQRS.Results.BrandResults;
using CareBook.Application.Features.Mediator.Queries.FeatureQueries;
using CareBook.Application.Features.Mediator.Results.FeatureResults;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.FeatureHandler
{
    public class GetFeatureByIDQueryHandler : IRequestHandler<GetFeatureByIdQuery, GetFeatureByIDQueryResult>
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureByIDQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<GetFeatureByIDQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIDAsync(request.ID);
            return new GetFeatureByIDQueryResult
            {
                FeatureID=values.FeatureID,
                Name = values.Name
            };
        }
    }
}
