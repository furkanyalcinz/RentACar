using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1,BrandId=1,CarClass="A",ColorId=2,DailyPrice= 300,Description="Benzinli Otomatik",ModelYear=2021},
                new Car{CarId = 2,BrandId=1,CarClass="B",ColorId=2,DailyPrice= 300,Description="Benzinli Otomatik",ModelYear=2020},
                new Car{CarId = 3,BrandId=2,CarClass="C",ColorId=2,DailyPrice= 200,Description="Dizel Otomatik",ModelYear=2019},
                new Car{CarId = 4,BrandId=2,CarClass="D",ColorId=2,DailyPrice= 240,Description="Dizel Otomatik",ModelYear=2016},
                new Car{CarId = 5,BrandId=3,CarClass="B",ColorId=2,DailyPrice= 250,Description="Dizel Otomatik",ModelYear=2018}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetCars()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => car.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarClass = car.CarClass;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
