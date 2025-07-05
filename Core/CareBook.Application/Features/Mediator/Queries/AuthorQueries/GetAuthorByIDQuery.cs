using CareBook.Application.Features.Mediator.Results.AuthorResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Queries.AuthorQueries
{
  public  class GetAuthorByIDQuery:IRequest<GetAuthorByIDQueryResult>
    {
        public int ID { get; set; }

        public GetAuthorByIDQuery(int iD)
        {
            ID = iD;
        }
    }
}
