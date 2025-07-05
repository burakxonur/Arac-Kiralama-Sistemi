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
    public class GetCarBrandandModelByRentPriceDailyMaxQueryHandler : IRequestHandler<GetCarBrandandModelByRentPriceDailyMaxQuery, GetCarBrandandModelByRentPriceDailyMaxQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarBrandandModelByRentPriceDailyMaxQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarBrandandModelByRentPriceDailyMaxQueryResult> Handle(GetCarBrandandModelByRentPriceDailyMaxQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarBrandandModelByRentPriceDailyMax();
            return new GetCarBrandandModelByRentPriceDailyMaxQueryResult
            {
                GetCarBrandandModelByRentPriceDailyMaxMyProperty = value,
            };
        }
    
    }
}
