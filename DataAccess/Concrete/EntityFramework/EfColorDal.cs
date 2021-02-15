using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.CarContext
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarDbContex>, IColorDal
    {

    }
}
