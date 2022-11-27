using Autofac;
using Business.Abstract;
using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        //uygulama ayağa kalktığında çalışıcak yer.
        protected override void Load(ContainerBuilder builder)
        {
            //product service isterse ona product manager instance ı ver.
            builder.RegisterType<ProductManager>().As<IProductService>();
        }
    }
}
