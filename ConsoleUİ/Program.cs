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

            var carResult = carManager.GetCarsDetails();

            if (carResult.Success)
            {
                foreach (var car in carResult.Data)
                {
                    Console.WriteLine("{0} -- {1} --- {2} --- {3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
                }
            }

            else
            {
                Console.WriteLine(carResult.Message);
            }

            Console.WriteLine("------------------------------------------");

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var brandResult = brandManager.GetAll();

            if (brandResult.Success)
            {
                foreach (var brand in brandResult.Data)
                {
                    Console.WriteLine("{0} -- {1}", brand.BrandId, brand.BrandName);
                }
            }

            else
            {
                Console.WriteLine(brandResult.Message);
            }

            Console.WriteLine("------------------------------------------");

            ColorManager colorManager = new ColorManager(new EfColorDal());

            var colorResult = colorManager.GetAll();

            if (colorResult.Success)
            {
                foreach (var color in colorResult.Data)
                {
                    Console.WriteLine("{0} -- {1}", color.ColorId, color.ColorName);
                }
            }

            else
            {
                Console.WriteLine(colorResult.Message);
            }
        }
    }
}
