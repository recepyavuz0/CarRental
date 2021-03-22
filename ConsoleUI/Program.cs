using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;
using Entities.Concreate;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car {
                BrandId = 1,
                ColorId = 2,
                DailyPrice = 400,
                ModelYear = "2018",
                Description = "A6 kaskolu"
            };
            
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine("---------- ARABA LİSTESİ ----------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} : {1} : {2} : {3} : {4} : {5}", car.Id,car.BrandId,car.ColorId,car.ModelYear,car.DailyPrice,car.Description);
            }

            carManager.Add(car1);
            Console.WriteLine(car1.Description+" Eklendi");

            Console.WriteLine("---------- ARABA LİSTESİ ----------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} : {1} : {2} : {3} : {4} : {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

        }
    }
}
