using CareBook.Application.Features.Mediator.Results.PricingResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingByIDQuery : IRequest<GetPricingByIDQueryResult>
    {
        public int ID { get; set; }

        public GetPricingByIDQuery(int iD)
        {
            ID = iD;
        }
    }
}
