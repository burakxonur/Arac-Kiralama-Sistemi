using CareBook.Application.Features.Mediator.Results.TagCloudResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudBYBlogIDQuery :IRequest<List<GetTagCloudBlogIDQueryResult>>
    {
        public int ID { get; set; }

        public GetTagCloudBYBlogIDQuery(int iD)
        {
            ID = iD;
        }
    }
}
