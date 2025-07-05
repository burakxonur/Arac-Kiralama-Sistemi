using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Queries.CategoryQueries
{
   public class GetCategoryByIDQuery
    {
        public int ID { get; set; }

        public GetCategoryByIDQuery(int iD)
        {
            ID = iD;
        }
    }
}
