using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Queries.BrandQueries
{
    public class GetBrandByIDQuery
    {
        public int ID { get; set; }

        public GetBrandByIDQuery(int iD)
        {
            ID = iD;
        }
    }
}
