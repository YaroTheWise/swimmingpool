using System.Web.Http;
using Ninject;
using Ninject.Extensions.Conventions;

namespace SwimmingPool.Web
{
    public class NinjectConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var kernel = BuildKernel();

            var ninjectDependencyResolver = new NinjectDependencyResolver(kernel);
            config.DependencyResolver = ninjectDependencyResolver;

            GlobalConfiguration.Configuration.DependencyResolver = ninjectDependencyResolver;
        }


        public static IKernel BuildKernel()
        {
            var kernel = new StandardKernel();
            
            kernel.Bind(x =>
                x.FromAssembliesMatching("SwimmingPool.*.dll")
                    .SelectAllClasses()
                    .BindAllInterfaces());
            
            return kernel;
        }
    }
}