using CareBook.Application.Features.Mediator.Results.SocialMediaResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Queries.SocialMediaQueries
{
 public   class GetSocialMediaByIdQuery:IRequest<GetSocialMediaByIdQuertResult>
    {
        public int ID { get; set; }

        public GetSocialMediaByIdQuery(int iD)
        {
            ID = iD;
        }
    }
}
