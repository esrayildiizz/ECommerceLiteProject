using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll(); //Liste şeklinde ürün döndürür.
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetByUnıtPrice(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails();
        Product GetById(int productId); //tek başına bir ürün döndürür.
        void Add(Product product); //void olduğu için birşey döndürmüyor.
    }
}
