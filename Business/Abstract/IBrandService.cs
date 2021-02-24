using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand brand);
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetByBrandsId(int id);
        IResult DeleteById(int id);



    }
}
