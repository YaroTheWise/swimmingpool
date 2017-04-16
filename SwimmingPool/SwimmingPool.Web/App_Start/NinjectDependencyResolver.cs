using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Ninject;

namespace SwimmingPool.Web
{
    class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel kernel;

        public NinjectDependencyResolver(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public void Dispose()
        {
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        public IDependencyScope BeginScope()
        {
            return this;
        }
    }
}