using CareBook.Application.Features.Mediator.Queries.PricingQueries;
using CareBook.Application.Features.Mediator.Results.PricingResults;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.PricingHandler
{
    public class GetPricingByIDQueryHandler : IRequestHandler<GetPricingByIDQuery, GetPricingByIDQueryResult>
    {
        private readonly IRepository<Pricing> _repository;

        public GetPricingByIDQueryHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task<GetPricingByIDQueryResult> Handle(GetPricingByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIDAsync(request.ID);
            return new GetPricingByIDQueryResult
            {
                PricingID = values.PricingID,
                Name = values.Name
            };
        }
    }
}
