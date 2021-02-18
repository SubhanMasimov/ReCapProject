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

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} -- {1} --- {2} --- {3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
            }

            Console.WriteLine("------------------------------------------");

            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Delete(new Color { ColorId = 11, ColorName = "Green" });

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("{0} -- {1}", brand.BrandId, brand.BrandName);
            }
        }
    }
}
