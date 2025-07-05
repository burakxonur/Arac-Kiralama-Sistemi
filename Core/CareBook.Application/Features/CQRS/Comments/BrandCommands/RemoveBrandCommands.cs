using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Comments.BrandCommands
{
   public class RemoveBrandCommands
    {
        public int ID { get; set; }

        public RemoveBrandCommands(int iD)
        {
            ID = iD;
        }
    }
}
