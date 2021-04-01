using Business.Concreate;
using Core.Utilities.Results;
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
            // ColorManager colorManager = new ColorManager(new EfColorDal());
            // UserManager();
            // CustomerManager();
            
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            Console.WriteLine(rentalManager.Add(new Rental()
            {
                CarId = 1,
                CustomerId = 1,
                RentDate = new DateTime(2021, 03, 30)
            }).Message);



        }

        private static void CustomerManager()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            Console.WriteLine(customerManager.Add(new Customer()
            {
                UserId = 2,
                CompanyName = "AAA Ajans"
            }));

            customerManager.Add(new Customer()
            {
                UserId = 3,
                CompanyName = "BBB Ajans"
            });

            customerManager.Add(new Customer()
            {
                UserId = 4,
                CompanyName = "BBB Ajans"
            });

            Console.WriteLine("------------------MÜŞTERİ LİSTESİ-------------------------");

            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine("{0} : {1} : {2}", customer.Id, customer.UserId, customer.CompanyName);
            }

            customerManager.Update(new Customer()
            {
                Id = 3,
                UserId = 4,
                CompanyName = "CCC Ajans"
            });

            Console.WriteLine("------------------MÜŞTERİ LİSTESİ-------------------------");

            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine("{0} : {1} : {2}", customer.Id, customer.UserId, customer.CompanyName);
            }

            customerManager.Delete(new Customer()
            {
                Id = 3
            });

            Console.WriteLine("------------------MÜŞTERİ LİSTESİ-------------------------");

            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine("{0} : {1} : {2}", customer.Id, customer.UserId, customer.CompanyName);
            }
        }

        private static void UserManager()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            userManager.Add(new User()
            {
                FirstName = "Recep Cafer",
                LastName = "Yavuz",
                Email = "reecptest@gmail.com",
                Password = "123456"
            });
            userManager.Add(new User()
            {
                FirstName = "Ali",
                LastName = "Demir",
                Email = "alitest@gmail.com",
                Password = "654321"
            });

            userManager.Add(new User()
            {
                FirstName = "Can",
                LastName = "Çelik",
                Email = "cantest@gmail.com",
                Password = "654321"
            });

            Console.WriteLine("------------------KULLANICI LİSTESİ-------------------------");
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine("{0} : {1} : {2} : {3} : {4}", user.Id, user.FirstName, user.LastName, user.Email, user.Password);
            }

            userManager.Delete(new User()
            {
                Id = 1
            });

            Console.WriteLine("------------------KULLANICI LİSTESİ-------------------------");
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine("{0} : {1} : {2} : {3} : {4}", user.Id, user.FirstName, user.LastName, user.Email, user.Password);
            }

            userManager.Update(new User()
            {
                Id = 3,
                FirstName = "Anıl",
                LastName = "Öz",
                Email = "aniltest@gmail.com",
                Password = "9876654"
            });

            Console.WriteLine("------------------KULLANICI LİSTESİ-------------------------");
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine("{0} : {1} : {2} : {3} : {4}", user.Id, user.FirstName, user.LastName, user.Email, user.Password);
            }
        }

        private static void BrandManager()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());


            Console.WriteLine("------------MARKA LİSTESİ-------------");
            foreach (var brand in brandManager.GetAll().Data)
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
            foreach (var brand in brandManager.GetAll().Data)
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
            foreach (var brand in brandManager.GetAll().Data)
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
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine("{0} : {1}", brand.Id, brand.Name);
            }
        }

        private static void CarManager()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("---------- ARABA LİSTESİ ----------------");
            foreach (var car in carManager.GetAll().Data)
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
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("{0} : {1} : {2} : {3} : {4} : {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            carManager.Delete(car1);
            Console.WriteLine(car1.Description + " Silindi");

            Console.WriteLine("---------- ARABA LİSTESİ ----------------");
            foreach (var car in carManager.GetAll().Data)
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
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("{0} : {1} : {2} : {3} : {4} : {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine("---------- ARABA DETAYLARI (JOIN) -----------------");
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("{0} : {1} : {2} : {3}", car.Description, car.BrandName, car.ColorName, car.DailyPrice);
            }
        }
    }
}
