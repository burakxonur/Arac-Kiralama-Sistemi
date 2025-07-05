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
    public class GetAvgRentPriceForDayQueryHandler : IRequestHandler<GetAvgRentPriceForDayQuery, GetAvgRentPriceForDayQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetAvgRentPriceForDayQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAvgRentPriceForDayQueryResult> Handle(GetAvgRentPriceForDayQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAvgRentPriceForDay();
            return new GetAvgRentPriceForDayQueryResult
            {
                AvgRentPriceForDay = value,
            };
        }
    }
}
