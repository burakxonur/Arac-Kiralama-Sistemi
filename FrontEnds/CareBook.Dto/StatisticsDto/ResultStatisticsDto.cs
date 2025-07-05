using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Dto.StatisticsDto
{
    public class ResultStatisticsDto
    {
        public int CarCount { get; set; }
        public int LocationCount { get; set; }
        public int AuthorCount { get; set; }
        public int BlogCount { get; set; }
        public int BrandCount { get; set; }
        public decimal AvgRentPriceForDay { get; set; }
        public decimal getAvgRentPriceForWeekly { get; set; }
        public decimal avgRentPriceForMountly { get; set; }
        public int CarCountByTransmissionIsAuto { get; set; }
        public string BrandNameByMaxCar { get; set; }
        public string blogTitleByMaxBlogComment { get; set; }
        public int carCountByKmSmallerThen1000 { get; set; }
        public int carCountByFuelGasolineOrDiesel { get; set; }
        public int carCountByFuelElectric { get; set; }
        public string getCarBrandandModelByRentPriceDailyMaxMyProperty { get; set; }
        public string getCarBrandandModelByRentPriceDailyMin { get; set; }
    }
}
