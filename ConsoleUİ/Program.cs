using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine("{0} --- {1} --- {2} --- {3} --- {4} --- {5}",
                    item.Id, item.BrandId, item.ColorId, item.ModelYear, item.DailyPrice, item.Description);
            }

            Console.WriteLine("-----------------------------");

            int id;
            id = Convert.ToInt32(Console.ReadLine());

            foreach (var car in carManager.GetCarsByColorId(id))
            {
                Console.WriteLine("{0} --- {1} --- {2} --- {3} --- {4} --- {5}",
                    car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine("-----------------------------");

            carManager.Add(new Car 
            {
                BrandId = 2,
                ColorId = 3,
                DailyPrice = 14,
                Description = "Petrol  Auto",
                ModelYear = 2011
            });

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine("{0} --- {1} --- {2} --- {3} --- {4} --- {5}",
                    item.Id, item.BrandId, item.ColorId, item.ModelYear, item.DailyPrice, item.Description);
            }

        }
    }
}
