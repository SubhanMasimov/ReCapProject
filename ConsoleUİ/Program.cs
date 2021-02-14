using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine("{0} --- {1} --- {2} --- {3} --- {4} --- {5}",
                    item.Id, item.BrandId, item.ColorId, item.ModelYear, item.DailyPrice, item.Description);
            }

            Console.WriteLine("-----------------------------");

            int id;
            id = Convert.ToInt32(Console.ReadLine());
            var car = carManager.GetById(id);

            Console.WriteLine("{0} --- {1} --- {2} --- {3} --- {4} --- {5}",
                    car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
        }
    }
}
