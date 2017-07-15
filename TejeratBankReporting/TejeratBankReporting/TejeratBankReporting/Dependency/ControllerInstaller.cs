using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace TejeratBankReporting.Dependency
{
    public class ControllerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(

                //All MVC controllers
                Classes.FromThisAssembly().BasedOn<IController>().LifestyleTransient()

                );
        }
    }
}