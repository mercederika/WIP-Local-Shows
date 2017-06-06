using Microsoft.Practices.Unity;
using System.Web.Http;
using System.Web.Mvc;
using Unity.WebApi;

namespace GoogleC29CrudApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            // sets up unity for API controllers
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);

            //sets up unity for MVC Controllers:
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));


        }
    }
}