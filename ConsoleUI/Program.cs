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
            // CarManager();
            // BrandManager();

            ColorManager colorManager = new ColorManager(new EfColorDal());

        }

        private static void BrandManager()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Console.WriteLine("------------MARKA LİSTESİ-------------");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("{0} : {1}", brand.Id, brand.Name);
            }

            Brand brand1 = new Brand
            {
                Name = "Tesla"
            };

            brandManager.Add(brand1);
            Console.WriteLine("Marka Eklendi");
            Console.WriteLine("------------MARKA LİSTESİ-------------");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("{0} : {1}", brand.Id, brand.Name);
            }

            Brand brand2 = new Brand
            {
                Id = 2,
                Name = "Bmw"
            };
            brandManager.Update(brand2);
            Console.WriteLine("Marka Güncellendi");
            Console.WriteLine("------------MARKA LİSTESİ-------------");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("{0} : {1}", brand.Id, brand.Name);
            }

            Brand brand3 = new Brand
            {
                Id = 3,
            };
            brandManager.Delete(brand3);
            Console.WriteLine("Marka Silindi");
            Console.WriteLine("------------MARKA LİSTESİ-------------");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("{0} : {1}", brand.Id, brand.Name);
            }
        }

        private static void CarManager()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("---------- ARABA LİSTESİ ----------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} : {1} : {2} : {3} : {4} : {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Car car1 = new Car
            {
                BrandId = 1,
                ColorId = 2,
                DailyPrice = 800,
                ModelYear = "2020",
                Description = "A8 kaskolu"
            };
            carManager.Add(car1);
            Console.WriteLine(car1.Description + " Eklendi");

            Console.WriteLine("---------- ARABA LİSTESİ ----------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} : {1} : {2} : {3} : {4} : {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            carManager.Delete(car1);
            Console.WriteLine(car1.Description + " Silindi");

            Console.WriteLine("---------- ARABA LİSTESİ ----------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} : {1} : {2} : {3} : {4} : {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Car car2 = new Car
            {
                Id = 1,
                BrandId = 1,
                ColorId = 2,
                DailyPrice = 700,
                ModelYear = "2018",
                Description = "A8 kaskosuz"
            };

            carManager.Update(car2);
            Console.WriteLine(car1.Description + " Güncellendi.");
            Console.WriteLine("---------- ARABA LİSTESİ ----------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} : {1} : {2} : {3} : {4} : {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine("---------- ARABA DETAYLARI (JOIN) -----------------");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} : {1} : {2} : {3}", car.Description, car.BrandName, car.ColorName, car.DailyPrice);
            }
        }
    }
}
