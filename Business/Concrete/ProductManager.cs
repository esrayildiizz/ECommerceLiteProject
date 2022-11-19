using Business.Abstract;
using Business.Contants;
using Core.Unitilies.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {



        IProductDal _productDal;

        public ProductManager(IProductDal productDal) //Constructor metot.
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            //Business kodlarını buraya yazarız.
            //örneğin kurallar vs varsa onlara bakıp sonra Add işlemi gerçekleşsin.
            if (product.ProductName.Length < 2)
            {
                //Burada parantez içinde sürekli uzun uzun yazmaktansa Messages adında oluşturduğum sabiti çağırdım.
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _productDal.Add(product);

            //Burada parantez içinde sürekli uzun uzun yazmaktansa Messages adında oluşturduğum sabiti çağırdım.
            return new SuccessResult(Messages.ProductAdded); 
        }

        
        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 20)
            {                                            //message
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime); //bakım zamanı demek.
            }
                                                         // T data,message
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<List<Product> >GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<Product> GetById(int productId)
        {
            //metot sadece product olduğu icin List eklemedik aşağıya.
            return new SuccessDataResult<Product>(_productDal.Get(x => x.ProductId == productId));
        }

        public IDataResult<List<Product>>GetByUnıtPrice(decimal min, decimal max)
        {
            return  new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }
    }
}
