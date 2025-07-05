using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Commands.FeatureCommands
{
  public  class RemoveFeatureCommand:IRequest
    {
        public int ID { get; set; }

        public RemoveFeatureCommand(int iD)
        {
            ID = iD;
        }
    }
}
