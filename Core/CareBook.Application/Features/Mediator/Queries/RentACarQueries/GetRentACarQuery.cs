﻿using CareBook.Application.Features.Mediator.Results.RentACarResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Queries.RentACarQueries
{
    public class GetRentACarQuery:IRequest<List<GetRentACarQueryResult>>
    {
        public int LocationID { get; set; }
        public bool Available { get; set; }
    }
}
