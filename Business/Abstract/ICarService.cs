﻿using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByCarId(int id);
        List<Car> GetAllByColorId(int id);
        List<Car> GetAllByBrandId(int id);
        List<CarDetailDto> GetCarDetails();
    }
}
