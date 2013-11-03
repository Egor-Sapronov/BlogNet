using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.Contracts;
using System.Web.Http;
using Data;
using Model;
using Ninject;

namespace Api
{
    public class IocConfig
    {
        public static void RegisterIoc(HttpConfiguration config)
        {
            var kernel = new StandardKernel(); //Ninject Ioc

            kernel.Bind<RepositoryFactories>().To<RepositoryFactories>()
                .InSingletonScope();

            kernel.Bind<IRepositoryProvider>().To<RepositoryProvider>();
            kernel.Bind<ISqlUow>().To<SqlUow>();

            config.DependencyResolver = new NinjectDependencyResolver(kernel);
        }
    }
}