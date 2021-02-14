using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
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

            Console.WriteLine("----------------GetAll()----------------");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3} -- {4} -- {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine("-------------GetCarsByBrandId-------------");

            //carManager.Add(new Car { BrandId = 2, ColorId = 3, ModelYear = 2014, DailyPrice = -25, Description = "Ma" }) ;

            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3} -- {4} -- {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine("--------------GetCarsByColorId--------------");

            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3} -- {4} -- {5}", car.Id, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine("-----------------Get()-----------------");

            Console.WriteLine(carManager.Get(2).Id + " " +  carManager.Get(2).Description);

            Console.WriteLine("---------------Delete()---------------");

            carManager.Delete(2);

            Console.WriteLine("Deleted");
        }
    }
}
