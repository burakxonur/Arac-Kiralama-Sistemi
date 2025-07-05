using CareBook.Application.Features.Mediator.Results.TagCloudResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudBYIDQuery : IRequest<GetTagCloudByIDQueryResult>
    {
        public int ID { get; set; }

        public GetTagCloudBYIDQuery(int iD)
        {
            ID = iD;
        }
    }
}
