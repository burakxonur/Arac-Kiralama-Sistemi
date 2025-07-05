using CareBook.Application.Features.Mediator.Queries.FooterAddressQueries;
using CareBook.Application.Features.Mediator.Results.FeatureResults;
using CareBook.Application.Features.Mediator.Results.FooterAddressResults;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.FooterAddressHandler
{
    public class GetFooterAddressByIDQueryHandler : IRequestHandler<GetFooterAddressByIDQuery, GetFooterAddresByIDQueryResult>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressByIDQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<GetFooterAddresByIDQueryResult> Handle(GetFooterAddressByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIDAsync(request.Id);
            return new GetFooterAddresByIDQueryResult
            {
                FooterAddressID = values.FooterAddressID,
                Address = values.Address,
                Description = values.Description,
                EMail = values.EMail,
                Telephone = values.Telephone
            };
        }
    }
}
