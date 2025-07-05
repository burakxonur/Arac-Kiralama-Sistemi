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
    public class BrandNameByMaxCarQueryHandler : IRequestHandler<BrandNameByMaxCarQuery, BrandNameByMaxCarQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public BrandNameByMaxCarQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<BrandNameByMaxCarQueryResult> Handle(BrandNameByMaxCarQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.BrandNameByMaxCar();
            return new BrandNameByMaxCarQueryResult
            {
                BrandNameByMaxCar = value,
            };
        }
    
    }
}
