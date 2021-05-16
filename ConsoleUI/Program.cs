using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car()
            {
                CarId = 4,
                BrandId = 3,
                ColorId = 2,
                Name = "Renoult Megane",
                ModelYear = 2021,
                DailyPrice = 350,
                Description = "Hatasız boyasız!"
            };
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(car1);
            foreach (var car in carManager.GetByDailyPrice(250,500))
            {
                Console.Write("Car Class " + car.CarClass + " ");
                Console.Write("Model Year " + car.ModelYear + " ");
                Console.Write("Color ID " + car.ColorId + " ");
                Console.Write("Name " + car.Name + " ");
                Console.Write("Description " + car.Description + " ");
                Console.WriteLine("Daily Price " + car.DailyPrice + " ");
            }

        }
    }
}
