﻿using CareBook.Application.Features.CQRS.Comments.CarCommands;
using CareBook.Application.İnterfaces;
using CareBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Handlers.CarHandlers
{
   public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommands command)
        {
            await _repository.CreateAsync(new Car
            {
                BrandID = command.BrandID,
                BigImageUrl = command.BigImageUrl,
                CoverImageUrl = command.CoverImageUrl,
                Fuel = command.Fuel,
                Km = command.Km,
                Luggage = command.Luggage,
                Model = command.Model,
                Seat = command.Seat,
                Transmission = command.Transmission,
                               
            });
        }
    }
}
