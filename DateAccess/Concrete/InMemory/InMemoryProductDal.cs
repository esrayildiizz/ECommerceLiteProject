﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {

        List<Product> _products; //veri tabanı olarak düşün.

        public InMemoryProductDal() //Constructor metot
        {
            _products = new List<Product> { 
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15, UnitsInStok=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500, UnitsInStok=3},
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500, UnitsInStok=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150, UnitsInStok=65},
                new Product{ProductId=5,CategoryId=2,ProductName="Bardak",UnitPrice=85, UnitsInStok=1}
            };
        }


        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //SingleOrDefault:_product daki tek değeri dön eğer değer yok ise default olarak getir.
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            //Tüm product ları dön.
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün id'sine sahir olan listedeki ürünü bul demek.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            //Gönderdiğim ürünlere göre güncelleme işlemi yapmak için gerekli kodlar.
            productToUpdate.ProductName = product.ProductName; 
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStok = product.UnitsInStok;
           
        }
    }
}
