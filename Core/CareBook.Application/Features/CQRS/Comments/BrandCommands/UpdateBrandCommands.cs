using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Comments.BrandCommands
{
    public class UpdateBrandCommands
    {
        public int BrandID { get; set; }
        public string Name { get; set; }
    }
}
