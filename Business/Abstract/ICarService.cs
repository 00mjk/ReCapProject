using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService
    {

        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarId(int Id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);

    }
}
