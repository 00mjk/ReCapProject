using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager()
        {
        }

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);

            return new SuccessResult(Messages.brandAdded);

        }

        public IResult DeleteById(int brandId)
        {
            var deletedCarEntity = _brandDal.Get(b => b.BrandId == brandId).BrandName;
            _brandDal.Delete(_brandDal.Get(b => b.BrandId == brandId));

            return new SuccessResult(Messages.brandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<List<Brand>> GetByBrandsId(int id)
        {
            if (id < 1)
            {
                return new ErrorDataResult<List<Brand>>(Messages.brandIdInvalid);
            }
            return new DataResult<List<Brand>>(_brandDal.GetAll(b => b.BrandId == id), true, Messages.brandIdInvalid);
        }

    }
}
