using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework.CarContext
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDbContex>, ICarDal
    {


        public List<CarDetailDto> GetCarDetails()
        {
            using (CarDbContex context = new CarDbContex())
            {
                var result = from c in context.Cars
                             join b in context.Brand
                             on c.BrandId equals b.BrandId
                             join co in context.Color
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description
                             };
                return result.ToList();
            }
        }
    }
}
