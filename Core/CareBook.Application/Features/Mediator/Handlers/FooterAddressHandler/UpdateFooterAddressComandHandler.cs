using CareBook.Application.Features.Mediator.Commands.FooterAddressCommands;
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
    public class UpdateFooterAddressComandHandler : IRequestHandler<UpdateFooterAddressCommnad>
    {
        private readonly IRepository<FooterAddress> _repository;

        public UpdateFooterAddressComandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterAddressCommnad request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIDAsync(request.FooterAddressID);
            values.Address = request.Address;
            values.Description = request.Description;
            values.EMail = request.EMail;
            values.Telephone = request.Telephone;
            await _repository.UpdatedAsync(values);
        }
    }
}
