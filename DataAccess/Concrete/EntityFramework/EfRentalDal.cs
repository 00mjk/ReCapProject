using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.CarContext;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDbContex>, IRentalDal
    {

        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter)
        {
            using (CarDbContex context = new CarDbContex())
            {
                var result = from re in filter is null ? context.Rental : context.Rental.Where(filter)
                             join c in context.Cars
                             on re.Id equals c.Id
                             join cu in context.Customer
                             on re.CustomerId equals cu.Id
                             join u in context.User
                             on cu.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 Id = re.Id,
                                 CustomerName = cu.CompanyName,
                                 CarId = c.Id,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate,
                                 UserName = u.FirstName + " " + u.LastName

                             };
                return result.ToList();
            }
        }
    }
}
