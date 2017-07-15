using Castle.Windsor;
using Castle.Windsor.Installer;
using TejeratBankReporting.Dependency;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Microsoft.Owin.Cors;
using System.Web.Mvc;
using Microsoft.Owin.Security.OAuth;
using System;
using TejeratBankReporting.Core;
using Castle.MicroKernel.Registration;
using System.ComponentModel;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

[assembly: OwinStartup(typeof(TejeratBankReporting.Web.Models.Authentication.API.Startup))]
namespace TejeratBankReporting.Web.Models.Authentication.API
{
    public class Startup
    {
        public static string PublicClientId { get; private set; }
        private WindsorContainer _windsorContainer;
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            //var container = SimpleInjectorConfig.Register();
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            //app.UseCookieAuthentication(new CookieAuthenticationOptions
            //{
            //    AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            //    LoginPath = new PathString("/Account/Login"),
            //    Provider = new CookieAuthenticationProvider
            //    {
            //        OnValidateIdentity = SecurityStampValidator
            //    .OnValidateIdentity<ApplicationUserManager, ApplicationUser, int>(
            //        validateInterval: TimeSpan.FromMinutes(30),
            //        regenerateIdentityCallback: (manager, user) =>
            //            user.GenerateUserIdentityAsync(manager),
            //        getUserIdCallback: (id) => (id.GetUserId<int>()))
            //    }
            //});

            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            _windsorContainer = new WindsorContainer();
            _windsorContainer.Install(FromAssembly.Containing<TejeratBankReportingDependencyInstaller>());
            PublicClientId = "self";
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);      
            var myprovider = new MyAutorizeServerProvider(PublicClientId);
            OAuthAuthorizationServerOptions option = new OAuthAuthorizationServerOptions
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = myprovider
            };
            app.UseOAuthAuthorizationServer(option);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
            //HttpConfiguration config = new HttpConfiguration();
            //WebApiConfig.Register(config);
        }   

    }
}