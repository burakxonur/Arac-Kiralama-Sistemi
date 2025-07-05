using CareBook.Application.Features.Mediator.Results.FooterAddressResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressByIDQuery:IRequest<GetFooterAddresByIDQueryResult>
    {
        public int Id { get; set; }

        public GetFooterAddressByIDQuery(int id)
        {
            Id = id;
        }
    }
}
