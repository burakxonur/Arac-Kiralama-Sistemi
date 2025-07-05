using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Commands.LocationCommands
{
  public  class RemoveLocationCommand:IRequest
    {
        public int ID { get; set; }

        public RemoveLocationCommand(int iD)
        {
            ID = iD;
        }
    }
}
