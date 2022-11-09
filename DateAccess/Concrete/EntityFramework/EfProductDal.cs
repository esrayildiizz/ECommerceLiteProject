using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //Bu yapı c# a özel bir yapı:
            //NorthwindContext bellekte işi bitince atılsın.
            using (NorthwindContext context =new NorthwindContext())
            {
                //git veri kaynağından benim gönderdiğim product dan bir tane nesneye eşleştir.
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
           
        }

        public void Delete(Product entity)
        {
            //Bu yapı c# a özel bir yapı:
            //NorthwindContext bellekte işi bitince atılsın.
            using (NorthwindContext context = new NorthwindContext())
            {
                //git veri kaynağından benim gönderdiğim product dan bir tane nesneye eşleştir.
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            //Bu yapı c# a özel bir yapı:
            //NorthwindContext bellekte işi bitince atılsın.
            using (NorthwindContext context = new NorthwindContext())
            {
                //git veri kaynağından benim gönderdiğim product dan bir tane nesneye eşleştir.
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
