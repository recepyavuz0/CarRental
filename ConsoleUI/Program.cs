using Business.Concreate;
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
                Id = 3,
                BrandId = 2,
                ColorId = 1,
                DailyPrice = 200,
                ModelYear = "2018",
                Description = "Günlük 200 TL temiz ve kaskolu"
            };
            Car car2 = new Car
            {
                Id = 1,
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 120,
                ModelYear = "2016",
                Description = "Günlük 120 TL temiz ve kaskolu"
            };
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("---------Tüm Liste---------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
                Console.WriteLine(car.BrandId);
                Console.WriteLine(car.ColorId);
                Console.WriteLine(car.ModelYear);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.Description);
                Console.WriteLine();
            }

            carManager.Add(car1);

            Console.WriteLine("---------Yeni Eklendi---------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
                Console.WriteLine(car.BrandId);
                Console.WriteLine(car.ColorId);
                Console.WriteLine(car.ModelYear);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.Description);
                Console.WriteLine();
            }

            carManager.Delete(car1);

            Console.WriteLine("---------Araba Silindi---------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
                Console.WriteLine(car.BrandId);
                Console.WriteLine(car.ColorId);
                Console.WriteLine(car.ModelYear);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.Description);
                Console.WriteLine();
            }

            carManager.Update(car2);

            Console.WriteLine("---------Araba Güncellendi---------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
                Console.WriteLine(car.BrandId);
                Console.WriteLine(car.ColorId);
                Console.WriteLine(car.ModelYear);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.Description);
                Console.WriteLine();
            }

            Console.WriteLine("---------ID ile Çağır---------");
            foreach (var car in carManager.GetById(2))
            {
                Console.WriteLine(car.Id);
                Console.WriteLine(car.BrandId);
                Console.WriteLine(car.ColorId);
                Console.WriteLine(car.ModelYear);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.Description);
                Console.WriteLine();
            }
            
        }
    }
}
