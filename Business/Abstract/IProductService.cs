using Core.Unitilies.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>>GetAll(); //Liste şeklinde ürün döndürür.
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnıtPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>>GetProductDetails();
        IDataResult<Product> GetById(int productId); //tek başına bir ürün döndürür.
        IResult Add(Product product); //void olduğu için birşey döndürmüyor. biz void yerine bundan sonra IResult yazdık.
    }
}
