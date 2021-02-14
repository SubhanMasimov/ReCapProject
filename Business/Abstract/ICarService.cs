using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car Get(int id);
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        void Add(Car entity);
        void Update(int id);
        void Delete(int id);
    }
}
