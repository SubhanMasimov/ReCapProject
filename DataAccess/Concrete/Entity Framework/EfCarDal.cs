using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var carToDelete = context.Set<Car>().SingleOrDefault(c => c.Id == id);
                context.Remove(carToDelete);
                context.SaveChanges();
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = context.Set<Car>().ToList();
                return result;
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = context.Set<Car>().SingleOrDefault(filter);
                return result;
            }
        }

        public List<Car> GetCarsByBrandId(Expression<Func<Car, bool>> filter)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = context.Set<Car>().Where(filter).ToList();
                return result;
            }
        }

        public List<Car> GetCarsByColorId(Expression<Func<Car, bool>> filter)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = context.Set<Car>().Where(filter).ToList();
                return result;
            }
        }

        public void Update(Car entity)
        {
            using (DatabaseContext context = new DatabaseContext())
            {

            }
        }
    }
}
