using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car entity)
        {
            if (entity.Description.Length > 2 && entity.DailyPrice > 0)
            {
                _carDal.Add(entity);
            }
            else
            {
                Console.WriteLine("Car added failed!");
            }
        }

        public void Delete(int id)
        {
            _carDal.Delete(c=>c.Id == id);
        }

        public Car Get(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetCarsByBrandId(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetCarsByColorId(c => c.ColorId == id);
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
