using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Commands.SocialMediaCommands
{
  public  class RemoveSocialMediaCommand:IRequest
    {
        public int ID { get; set; }

        public RemoveSocialMediaCommand(int iD)
        {
            ID = iD;
        }
    }
}
