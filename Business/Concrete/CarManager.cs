using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
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

        public IResult Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult();
            }

            return new ErrorResult();
        }

        public IResult Delete(Car car)
        {
            if (car.Id > 0)
            {
                _carDal.Delete(car);
                return new SuccessResult();
            }

            return new ErrorResult();
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == id));
        }

        public IDataResult<List<CarDetailsDto>> GetCarsDetails()
        {
            if (DateTime.Now.Hour >= 21)
            {
                return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails(), Messages.CarsListed);
            }

            return new ErrorDataResult<List<CarDetailsDto>>(Messages.CarsNoListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
        }

        public IResult Update(Car car)
        {
            if (car.Id > 0 && car.CarName.Length > 2)
            {
                _carDal.Update(car);
                return new SuccessResult();
            }

            return new ErrorResult();
        }
    }
}
