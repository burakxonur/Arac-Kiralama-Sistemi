using CareBook.Application.Features.Mediator.Results.FeatureResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Queries.FeatureQueries
{
   public class GetFeatureByIdQuery:IRequest<GetFeatureByIDQueryResult>
    {
        public int ID { get; set; }

        public GetFeatureByIdQuery(int iD)
        {
            ID = iD;
        }
    }
}
