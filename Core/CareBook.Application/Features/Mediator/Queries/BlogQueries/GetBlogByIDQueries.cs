﻿using CareBook.Application.Features.Mediator.Results.BlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Queries.BlogQueries
{
 public   class GetBlogByIDQueries:IRequest<GetBlogByIDQueryResult>
    {
        public int ID { get; set; }

        public GetBlogByIDQueries(int iD)
        {
            ID = iD;
        }
    }
}
