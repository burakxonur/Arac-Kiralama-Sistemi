﻿using CareBook.Application.Features.Mediator.Commands.ServiceCommands;
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
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand>
    {
        private readonly IRepository<Service> _repository;

        public CreateServiceCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Service
            {
                Title = request.Title,
                Description = request.Description,
                IconUrl = request.IconUrl
            });
        }
    }
}
