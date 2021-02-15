using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        IDataResult<List<Color>> IColorService.GetAll()
        {
            return new DataResult<List<Color>>(_colorDal.GetAll(), true);
        }

        IDataResult<List<Color>> IColorService.GetByColorId(int ColorId)
        {
            if (ColorId < 1)
            {
                return new ErrorDataResult<List<Color>>(Messages.colorIdInvalid);
            }
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(c => c.ColorId == ColorId));
        }
    }
}
