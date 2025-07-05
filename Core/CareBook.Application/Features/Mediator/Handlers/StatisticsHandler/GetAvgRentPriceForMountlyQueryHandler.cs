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
    public class GetAvgRentPriceForMountlyQueryHandler : IRequestHandler<GetAvgRentPriceForMountlyQuery, GetAvgRentPriceForMountlyQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetAvgRentPriceForMountlyQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAvgRentPriceForMountlyQueryResult> Handle(GetAvgRentPriceForMountlyQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAvgRentPriceForMountly();
            return new GetAvgRentPriceForMountlyQueryResult
            {
                AvgRentPriceForMountly = value,
            };
        }
    
    }
}
