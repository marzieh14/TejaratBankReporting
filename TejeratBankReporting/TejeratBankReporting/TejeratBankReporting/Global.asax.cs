using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TejeratBankReporting.Dependency;

namespace TejeratBankReporting
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private WindsorContainer _windsorContainer;
        protected void Application_Start()
        {

            InitializeWindsor(System.Web.Http.GlobalConfiguration.Configuration);
            GlobalConfiguration.Configure(c => WebApiConfig.Register(c, _windsorContainer));
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_End()
        {
            if (_windsorContainer != null)
            {
                _windsorContainer.Dispose();
            }
        }

        private void InitializeWindsor(HttpConfiguration configuration)
        {
            _windsorContainer = new WindsorContainer();
            _windsorContainer.Install(FromAssembly.Containing<TejeratBankReportingDependencyInstaller>());
            //_windsorContainer.Install(FromAssembly.Containing<MyAutorizeServerProvider>(_windsorContainer.Kernel,true));
            _windsorContainer.Install(FromAssembly.This());

            _windsorContainer.Kernel.Resolver.AddSubResolver(new CollectionResolver(_windsorContainer.Kernel, true));
            var dependencyResolver = new WindsorDependencyResolver(_windsorContainer);
            configuration.DependencyResolver = dependencyResolver;
            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(_windsorContainer.Kernel));

        }
    }
}
