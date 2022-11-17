using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //Category ile ilgili dış dünyaya neyi servis etmek istiyorsam o operasyonları yazıyorum.
    public interface ICategoryService
    {
        List<Category> GetAll();

        Category GetById(int categoryId); //tek bir categori getireceği için List yazmadık.
    }
}
