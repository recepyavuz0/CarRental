using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapContext context =new ReCapContext())
            {
                var result = from r in context.Rentals
                            join car in context.Cars
                            on r.CarId equals car.Id
                            join customer in context.Customers
                            on r.CustomerId equals customer.Id
                            select new RentalDetailDto
                            {
                                Description = car.Description,
                                CompanyName = customer.CompanyName,
                                RentDate = r.RentDate,
                                ReturnDate = r.ReturnDate.Value
                            };
                return result.ToList();

            }

            
        }
    }
}
