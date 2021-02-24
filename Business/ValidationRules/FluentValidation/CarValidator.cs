using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CarValidator : AbstractValidator<CarDetailDto>
    {
        public CarValidator()
        {

            #region Araba 
            RuleFor(p => p.BrandName).NotEmpty();
            RuleFor(p => p.BrandName).MinimumLength(2);
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.Description).NotEmpty();       
            RuleFor(p => p.ColorName).NotEmpty();
            RuleFor(p => p.ColorName).MinimumLength(2);
            #endregion

        }

    }
}
