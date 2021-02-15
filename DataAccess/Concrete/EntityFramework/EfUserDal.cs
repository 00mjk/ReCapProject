using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.CarContext
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarDbContex>, IUserDal
    {

    }
}
