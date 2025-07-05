using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Results.CarPricingResults
{
    public class GetCarPricingWithTimePeriodQueryResult
    {
        public string Model { get; set; }
        public decimal DailyAmount { get; set; }
        public decimal WeekAmount { get; set; }
        public decimal MounthAmount { get; set; }
        public string CoverImageUrl { get; set; }
    }
}
