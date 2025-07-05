using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Dto.RentACarDto
{
    public class FilterRentACarDto
    {
        public int carID { get; set; }
        public String Brand { get; set; }
        public String Model { get; set; }
        public decimal Amount { get; set; }
        public string CoverImageUrl { get; set; }
    }
}
