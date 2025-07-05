using CareBook.Application.İnterfaces.CarPricingInterfaces;
using CareBook.Application.ViewModel;
using CareBook.Domain.Entities;
using CareBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Persistence.Repository.CarPricingRepositories
{
    public class CatPricingRepository : ICarPricingRepository
    {
        private readonly CarBookContext _context;

        public CatPricingRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<CarPricing> GetCarPricingWithCars()
        {
            var values = _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand).Include(z => z.Pricing).Where(t => t.PricingID == 2).ToList();
            return values;
        }

        public List<CarPricing> GetCarPricingWithTimePeriod()
        {
            throw new NotImplementedException();
        }

        public List<CarPricingViewModel> GetCarPricingWithTimePeriod1()
        {
            List<CarPricingViewModel> values = new List<CarPricingViewModel>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "Select * From(Select Model,CoverImageUrl,PricingID,Amount From CarPricings Inner Join Cars On\r\n Cars.CarID=CarPricings.CarID Inner Join Brands On Brands.BrandID=Cars.BrandID) As SourceTable Pivot (Sum(Amount) For PricingID In ([2],[3],[5])) As PivotTable;";
                command.CommandType = System.Data.CommandType.Text;
                _context.Database.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CarPricingViewModel carPricingViewModel = new CarPricingViewModel()
                        {
                            Model = reader["Model"].ToString(),
                            CoverImageUrl = reader["CoverImageUrl"].ToString(),
                            Amount = new List<decimal>
{
    reader.IsDBNull(2) ? 0 : Convert.ToDecimal(reader[2]), // [2]
    reader.IsDBNull(3) ? 0 : Convert.ToDecimal(reader[3]), // [3]
    reader.IsDBNull(4) ? 0 : Convert.ToDecimal(reader[4])  // [5] → dikkat!
}
                        };
                        values.Add(carPricingViewModel);
                    }
                }
                _context.Database.CloseConnection();
                return values;
            }
        }
    }
}






//var values = from x in _context.CarPricings
//             group x by x.PricingID into g
//             select new
//             {
//                 CarID = g.Key,
//                 DailyAmount = g.Where(y => y.CarPricingID == 2).Sum(z => z.Amount),
//                 WeekAmount = g.Where(y => y.CarPricingID == 3).Sum(z => z.Amount),
//                 MounthAmount = g.Where(y => y.CarPricingID == 5).Sum(z => z.Amount),

//             };







//public List<CarPricing> GetCarPricingWithTimePeriod()
//{
//    //List<CarPricing> values = new List<CarPricing>();
//    //using (var command = _context.Database.GetDbConnection().CreateCommand())
//    //{
//    //    command.CommandText = "Select * From(Select Model,PricingID,Amount From CarPricings Inner Join Cars On\r\n Cars.CarID=CarPricings.CarID Inner Join Brands On Brands.BrandID=Cars.BrandID) As SourceTable Pivot (Sum(Amount) For PricingID In ([2],[3],[5])) As PivotTable;";
//    //    command.CommandType = System.Data.CommandType.Text;
//    //    _context.Database.OpenConnection();
//    //    using (var reader = command.ExecuteReader())
//    //    {
//    //        while (reader.Read())
//    //        {
//    //            CarPricing carPricing = new CarPricing();
//    //            Enumerable.Range(1, 3).ToList().ForEach(x =>
//    //            {
//    //                if (DBNull.Value.Equals(reader[x]))
//    //                {
//    //                    carPricing.
//    //                }
//    //                else
//    //                {
//    //                    carPricing.Amount
//    //                }

//    //            });
//    //            values.Add(carPricing);
//    //        }
//    //    }
//    //    _context.Database.CloseConnection();
//    //    return values;
//    //}
//}