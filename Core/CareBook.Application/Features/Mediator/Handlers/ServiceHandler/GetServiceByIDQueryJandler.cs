using CareBook.Application.Features.Mediator.Queries.ServiceQueries;
using CareBook.Application.Features.Mediator.Results.LocationResults;
using CareBook.Application.Features.Mediator.Results.ServiceResults;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.ServiceHandler
{
    public class GetServiceByIDQueryJandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIDQueryResults>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceByIDQueryJandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIDQueryResults> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIDAsync(request.ID);
            return new GetServiceByIDQueryResults
            {
                ServiceID = values.ServiceID,
                Title = values.Title,
                Description = values.Description,
                IconUrl = values.IconUrl,
            };
        }
    }
}
