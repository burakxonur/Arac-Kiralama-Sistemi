using CareBook.Application.Features.Mediator.Commands.ServiceCommands;
using CareBook.Application.Features.Mediator.Commands.SocialMediaCommands;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Handlers.SocialMediaHandler
{
    public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommand>
    {
        private readonly IRepository<SocialMedia> _repository;

        public UpdateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIDAsync(request.SocialMediaID);
            values.Name = request.Name;
            values.Url = request.Url;
            values.Icon = request.Icon;
            await _repository.UpdatedAsync(values);
        }
    }
}
