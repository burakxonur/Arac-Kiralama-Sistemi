﻿using CareBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.İnterfaces.CarInterfaces
{
    public interface ICarRepository
    {
        List<Car> GetCarsListWithBrand();
        List<Car> GetLast5withCarsWithBrand();
        int GetCarCount();
        
    }
}
