using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Comments.AboutComments
{
    public class RemoveAboutCommand
    {
        public RemoveAboutCommand(int id)
        {
            ID = id;
        }

        public int ID { get; set; }
    }
}
