using CareBook.Application.Features.Mediator.Results.TestimonialResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Queries.TestimonialQueries
{
  public  class GetTestimonialByIdQuery:IRequest<GetTestimonailByIdQueryResult>
    {
        public int ID { get; set; }

        public GetTestimonialByIdQuery(int iD)
        {
            ID = iD;
        }
    }
}
