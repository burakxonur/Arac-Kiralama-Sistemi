using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Commands.CarFeatureCommands
{
    public class UpdateCarFeatureAvailableChangeToTrueCommand:IRequest
    {
        public int ID { get; set; }

        public UpdateCarFeatureAvailableChangeToTrueCommand(int iD)
        {
            ID = iD;
        }
    }
}
