using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Dto.CarPricingDto
{
    public class ResultCarPrcingListWithModelDto
    {
        public string Model { get; set; }
        public decimal dailyAmount { get; set; }
        public decimal weekAmount { get; set; }
        public decimal mounthAmount { get; set; }
        public string CoverImageUrl { get; set; }
    }
}
