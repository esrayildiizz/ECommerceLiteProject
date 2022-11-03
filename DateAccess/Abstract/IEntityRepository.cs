using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        //Bütün ürünleri çek getir.
        List<T> GetAll();
        T Get(Expression<Func<T, bool>> filter); 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //Şartlı listeleme
        List<T> List(Expression<Func<T, bool>> filter);


    }

}
