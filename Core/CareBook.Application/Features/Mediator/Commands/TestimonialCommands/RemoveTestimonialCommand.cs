using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Commands.TestimonialCommands
{
  public  class RemoveTestimonialCommand:IRequest
    {
        public int ID { get; set; }

        public RemoveTestimonialCommand(int iD)
        {
            ID = iD;
        }
    }
}
