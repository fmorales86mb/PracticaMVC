using Business.Cutura;
using Business.Interfaces;
using ResourceAccess.Cultura;
using ResourceAccess.Interfaces;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace WebApiMiddleware
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ICulturaResourceAccess, CulturaResourceAccess>();
            container.RegisterType<ICulturaBusiness, CulturaBusiness>();
            /*
             * Para que Unity funcione en los controllers hay que agregar en el Global.asax: UnityConfig.RegisterComponents()
            */

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}