using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Commands.FooterAddressCommands
{
    public class CreateFooterAddressCommand : IRequest
    {
        public string Description { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string EMail { get; set; }
    }
}
