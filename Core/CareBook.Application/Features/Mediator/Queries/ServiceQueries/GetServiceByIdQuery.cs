using CareBook.Application.Features.Mediator.Results.ServiceResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Queries.ServiceQueries
{
 public   class GetServiceByIdQuery:IRequest<GetServiceByIDQueryResults>
    {
        public int ID { get; set; }

        public GetServiceByIdQuery(int iD)
        {
            ID = iD;
        }
    }
}
