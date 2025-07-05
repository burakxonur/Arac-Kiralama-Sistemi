using CareBook.Application.Features.CQRS.Queries.BrandQueries;
using CareBook.Application.Features.CQRS.Queries.CarQueries;
using CareBook.Application.Features.CQRS.Results.BrandResults;
using CareBook.Application.Features.CQRS.Results.CarResults;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIDQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIDQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<GetCarByIDQueryResult> Handle(GetCarByIDQuery query)
        {
            var values = await _repository.GetByIDAsync(query.Id);
            return new GetCarByIDQueryResult
            {
                BrandID = values.BrandID,
                BigImageUrl = values.BigImageUrl,
                CarID = values.CarID,
                CoverImageUrl = values.CoverImageUrl,
                Fuel = values.Fuel,
                Km = values.Km,
                Luggage = values.Luggage,
                Model = values.Model,
                Seat = values.Seat,
                Transmission = values.Transmission
            };
        }
    }
}
