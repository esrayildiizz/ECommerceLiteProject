using Business.Abstract;
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
            _productDal.Add(product);
            return new Result(true,"Ürün eklendi.");
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(x => x.ProductId == productId);
        }

        public List<Product> GetByUnıtPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
