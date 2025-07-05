using CareBook.Application.Features.Mediator.Queries.RentACarQueries;
using CareBook.Application.Features.Mediator.Results.RentACarResults;
using CareBook.Application.İnterfaces.RentACarInterfaces;
using CareBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.RentACarHandlers
{
    public class GetRentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        private readonly IRentACarRepository _repository;

        public GetRentACarQueryHandler(IRentACarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsync(x => x.LocationID == request.LocationID && x.Available == true);
            var result = values.Select(y => new GetRentACarQueryResult
            {
                CarID = y.CarID,
                Brand = y.Car?.Brand?.Name ?? "Markasız",
                Model = y.Car?.Model ?? "Modelsiz",
                CoverImageUrl = y.Car?.CoverImageUrl ?? ""
            }).ToList();
            return result;
        }
    }
}
