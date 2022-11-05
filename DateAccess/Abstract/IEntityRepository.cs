using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //T tipi için kısıtlama getirdik yani herkes istediğini yazamasın.
    //generic constaint :kısıtlama
    public interface IEntityRepository<T> where T:class,IEntity
    {
        //Bütün ürünleri çek getir.
        //Şartlı listeleme
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);  //tek bir data getirmek için
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
        


    }

}
