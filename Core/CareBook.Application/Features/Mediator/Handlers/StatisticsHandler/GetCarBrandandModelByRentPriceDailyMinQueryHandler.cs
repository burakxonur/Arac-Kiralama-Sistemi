using CareBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CareBook.Application.Features.Mediator.Results.StatisticsResult;
using CareBook.Application.İnterfaces.StatisticsInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.StatisticsHandler
{
    public class GetCarBrandandModelByRentPriceDailyMinQueryHandler : IRequestHandler<GetCarBrandandModelByRentPriceDailyMinQuery, GetCarBrandandModelByRentPriceDailyMinQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarBrandandModelByRentPriceDailyMinQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarBrandandModelByRentPriceDailyMinQueryResult> Handle(GetCarBrandandModelByRentPriceDailyMinQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarBrandandModelByRentPriceDailyMin();
            return new GetCarBrandandModelByRentPriceDailyMinQueryResult
            {
                GetCarBrandandModelByRentPriceDailyMin = value,
            };
        }
    
    }
}
