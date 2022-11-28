using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //.ProductName boş olamaz.Ve bu mesaj önümüze gelir.
            RuleFor(x =>x.ProductName).NotEmpty().WithMessage("Ürün Adını Boş Geçemezsiniz.");
            //CategoryDescription boş olamaz.Ve bu mesaj önümüze gelir.
            RuleFor(x => x.UnitPrice).NotEmpty().WithMessage("Ürün Fiyat Alanını Boş Geçemezsiniz.");

            RuleFor(x => x.ProductName).MinimumLength(3).WithMessage("Lütfen en az 3 karater girişi yapınız.");

           
        }
    }
}
