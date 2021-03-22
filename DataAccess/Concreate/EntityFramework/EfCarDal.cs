using DataAccess.Abstract;
using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (ReCapContext context=new ReCapContext())
            {
                var addedToCar = context.Entry(entity);
                addedToCar.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var deletedToCar = context.Entry(entity);
                deletedToCar.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapContext context=new ReCapContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }
        public void Update(Car entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var updatedToCar = context.Entry(entity);
                updatedToCar.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
