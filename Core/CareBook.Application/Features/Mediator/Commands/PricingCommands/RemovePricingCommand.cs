using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Commands.PricingCommands
{
  public  class RemovePricingCommand:IRequest
    {
        public int ID { get; set; }

        public RemovePricingCommand(int iD)
        {
            ID = iD;
        }
    }
}
