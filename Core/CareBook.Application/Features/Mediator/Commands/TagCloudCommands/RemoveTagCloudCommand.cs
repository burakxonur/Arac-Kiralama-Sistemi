using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Commands.TagCloudCommands
{
 public   class RemoveTagCloudCommand:IRequest
    {
        public int ID { get; set; }

        public RemoveTagCloudCommand(int iD)
        {
            ID = iD;
        }
    }
}
