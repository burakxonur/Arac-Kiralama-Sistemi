using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.CQRS.Queries.CarQueries
{
   public class GetCarByIDQuery
    {
        public int Id { get; set; }

        public GetCarByIDQuery(int id)
        {
            Id = id;
        }
    }
}
