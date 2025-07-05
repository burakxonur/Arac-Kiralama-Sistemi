using CareBook.Application.Features.Mediator.Commands.PricingCommands;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.PricingHandler
{
    public class UpdatePricingCommandHandler : IRequestHandler<UpdatePricingCommand>
    {
        private readonly IRepository<Pricing> _repository;

        public UpdatePricingCommandHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdatePricingCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIDAsync(request.PricingID);
            values.Name = request.Name;
            await _repository.UpdatedAsync(values);
        }
    }
}
