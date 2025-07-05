using CareBook.Application.Features.Mediator.Results.LocationResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Queries.LocationQueries
{
    public class GetLocationByIDQuery : IRequest<GetLocationByIDQueryResult>
    {
        public int ID { get; set; }

        public GetLocationByIDQuery(int iD)
        {
            ID = iD;
        }
    }
}
