using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Queries.AboutQueries
{
    public class GetAboutByIDQuery
    {
        public GetAboutByIDQuery(int iD)
        {
            ID = iD;
        }

        public int ID { get; set; }
    }
}
