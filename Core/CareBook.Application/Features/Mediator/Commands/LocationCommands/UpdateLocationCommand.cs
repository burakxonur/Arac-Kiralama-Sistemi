﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Commands.LocationCommands
{
    public class UpdateLocationCommand : IRequest
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
    }
}
