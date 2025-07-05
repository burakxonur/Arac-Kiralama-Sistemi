using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Commands.AuthorCommands
{
    public class RemoveAuthorCommand:IRequest
    {
        public int ID { get; set; }

        public RemoveAuthorCommand(int iD)
        {
            ID = iD;
        }
    }
}
