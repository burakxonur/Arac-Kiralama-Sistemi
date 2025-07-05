using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Comments.CategoryCommands
{
public    class RemoveCategoryCommands
    {
        public int ID { get; set; }

        public RemoveCategoryCommands(int iD)
        {
            ID = iD;
        }
    }
}
