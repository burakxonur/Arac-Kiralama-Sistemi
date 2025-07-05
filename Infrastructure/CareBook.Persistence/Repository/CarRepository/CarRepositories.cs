using CareBook.Application.İnterfaces.CarInterfaces;
using CareBook.Domain.Entities;
using CareBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Persistence.Repository.CarRepository
{
    public class CarRepositories : ICarRepository
    {
        private readonly CarBookContext _context;

        public CarRepositories(CarBookContext context)
        {
            _context = context;
        }

        public int GetCarCount()
        {
            var value=_context.Cars.Count();
            return value;
        }

        public List<Car> GetCarsListWithBrand()
        {
            var values = _context.Cars.Include(x => x.Brand).ToList();
            return values;
        }


        public List<Car> GetLast5withCarsWithBrand()
        {
            var values = _context.Cars.Include(x => x.Brand).OrderByDescending(x => x.CarID).Take(5).ToList();
            return values;

        }
    }
}
