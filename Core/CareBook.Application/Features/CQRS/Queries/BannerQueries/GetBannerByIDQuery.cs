using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Queries.BannerQueries
{
    public class GetBannerByIDQuery
    {
        public int ID { get; set; }

        public GetBannerByIDQuery(int iD)
        {
            ID = iD;
        }
    }
}
