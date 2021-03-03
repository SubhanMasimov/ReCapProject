using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManagerResultTest();

            //Console.WriteLine("------------------------------------------");

            //BrandManagerResultTest();

            //ColorManagerResultTest();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Add(new Rental { CarId = 5, CustomerId = 1, RentDate = DateTime.Now });

            if (result.Success)
            {
                foreach (var rental in rentalManager.GetAll().Data)
                {
                    Console.WriteLine("{0} -- {1} --- {2} --- {3} -- {4}", rental.RentalId, rental.CarId, rental.CustomerId, rental.RentDate, rental.ReturnDate);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }

        }

        #region Test Methods
        private static void ColorManagerResultTest()
        {
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

        private static void BrandManagerResultTest()
        {
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
        }

        private static void CarManagerResultTest()
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
        }
        #endregion
    }
}
