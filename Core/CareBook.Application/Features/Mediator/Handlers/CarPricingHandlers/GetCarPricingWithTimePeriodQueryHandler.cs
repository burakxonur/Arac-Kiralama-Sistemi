using CareBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CareBook.Application.Features.Mediator.Results.CarPricingResults;
using CareBook.Application.İnterfaces.CarPricingInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithTimePeriodQueryHandler : IRequestHandler<GetCarPricingWithTimePeriodQuery, List<GetCarPricingWithTimePeriodQueryResult>>
    {
        private readonly ICarPricingRepository _repository;

        public GetCarPricingWithTimePeriodQueryHandler(ICarPricingRepository repository )
        {
            _repository = repository;
        }

        public async Task<List<GetCarPricingWithTimePeriodQueryResult>> Handle(GetCarPricingWithTimePeriodQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCarPricingWithTimePeriod1();
            return values.Select(x => new GetCarPricingWithTimePeriodQueryResult
            {
                
                Model=x.Model,
                CoverImageUrl = x.CoverImageUrl,
                DailyAmount = x.Amount[0],
                WeekAmount = x.Amount[1],
                MounthAmount = x.Amount[2],
            }).ToList();
        }
    }
}
