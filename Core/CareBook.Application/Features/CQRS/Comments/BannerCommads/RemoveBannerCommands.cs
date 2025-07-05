using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Comments.BannerCommads
{
   public class RemoveBannerCommands
    {
        public int Id { get; set; }

        public RemoveBannerCommands(int id)
        {
            Id = id;
        }
    }
}
