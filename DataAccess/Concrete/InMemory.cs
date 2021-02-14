using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemory : ICarDal
    {
        List<Car> _cars;
        public InMemory()
        {
            _cars = new List<Car> {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear="2016",DailyPrice=130,Description="Beyaz Renault Symbol Dizel Manuel"},
                new Car{CarId=2,BrandId=1,ColorId=3,ModelYear="2017",DailyPrice=150,Description="Mavi Renault Clio Dizel Manuel"},
                new Car{CarId=3,BrandId=2,ColorId=1,ModelYear="2017",DailyPrice=275,Description="Beyaz Hyundai Elantra Dizel Otomatik"},
                new Car{CarId=4,BrandId=2,ColorId=2,ModelYear="2018",DailyPrice=165,Description="Gri Hyundai Accent Dizel Otomatik"},
                new Car{CarId=5,BrandId=3,ColorId=1,ModelYear="2016",DailyPrice=60,Description="Beyaz Porsche Cayenne Benzin Otomatik"}

            };
        }

        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        { 
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }

    }
}
