﻿using CareBook.Application.Features.Mediator.Results.BlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Queries.BlogQueries
{
  public  class GetLast3BlogWithAuthorsQuery:IRequest<List<GetLast3BlogWithAuthorsQueryResult>>
    {
    }
}
