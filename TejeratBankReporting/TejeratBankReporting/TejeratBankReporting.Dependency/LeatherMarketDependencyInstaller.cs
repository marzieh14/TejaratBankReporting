using System.Configuration;
using System.Reflection;
using Castle.Core;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using TejeratBankReporting.Data.Nhibernate;
using TejeratBankReporting.Core;
using LeatherMarket.Data.Nhibernate;

namespace TejeratBankReporting.Dependency
{
    public class TejeratBankReportingDependencyInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Kernel.ComponentRegistered += Kernel_ComponentRegistered;

            //Register all components
            container.Register(
                //Nhibernate session factory
                Component.For<ISessionFactory>().UsingFactoryMethod(CreateNhSessionFactory).LifeStyle.Singleton,
                //Unitofwork interceptor
                Component.For<NhUnitOfWorkInterceptor>().LifeStyle.Transient,
                       //All repoistories
                       //Classes.FromAssembly(Assembly.GetAssembly(typeof(NHInstallmentRepository))).
                       //InSameNamespaceAs<NHInstallmentRepository>().WithService.DefaultInterfaces().LifestyleTransient(),
                       // Classes.FromAssembly(Assembly.GetAssembly(typeof(NHNacLogRepository))).
                       //InSameNamespaceAs<NHNacLogRepository>().WithService.DefaultInterfaces().LifestyleTransient(),
                Classes.FromAssembly(Assembly.GetAssembly(typeof(NHNacRepository))).
                InSameNamespaceAs<NHNacRepository>().WithService.DefaultInterfaces().LifestyleTransient(),

                Classes.FromAssembly(Assembly.GetAssembly(typeof(NHSubscriptionRepository))).
                InSameNamespaceAs<NHSubscriptionRepository>().WithService.DefaultInterfaces().LifestyleTransient(),

                 Classes.FromAssembly(Assembly.GetAssembly(typeof(NHTransactionRepository))).
                InSameNamespaceAs<NHTransactionRepository>().WithService.DefaultInterfaces().LifestyleTransient(),

                 Classes.FromAssembly(Assembly.GetAssembly(typeof(NHNacLogRepository))).
                InSameNamespaceAs<NHNacLogRepository>().WithService.DefaultInterfaces().LifestyleTransient(),
                   //All services
                   //Classes.FromAssembly(Assembly.GetAssembly(typeof(InstallmentService))).
                   //InSameNamespaceAs<InstallmentService>().WithService.DefaultInterfaces().LifestyleTransient(),
                   Classes.FromAssembly(Assembly.GetAssembly(typeof(TransactionService))).
                InSameNamespaceAs<TransactionService>().WithService.DefaultInterfaces().LifestyleTransient(),

                 Classes.FromAssembly(Assembly.GetAssembly(typeof(NacLogService))).
                InSameNamespaceAs<NacLogService>().WithService.DefaultInterfaces().LifestyleTransient(),

                 Classes.FromAssembly(Assembly.GetAssembly(typeof(SubscriptionService))).
                InSameNamespaceAs<SubscriptionService>().WithService.DefaultInterfaces().LifestyleTransient(),

                 Classes.FromAssembly(Assembly.GetAssembly(typeof(NacService))).
                InSameNamespaceAs<NacService>().WithService.DefaultInterfaces().LifestyleTransient()
                //   Classes.FromAssembly(Assembly.GetAssembly(typeof(NacLogService))).
                //InSameNamespaceAs<NacLogService>().WithService.DefaultInterfaces().LifestyleTransient(),
                //Classes.FromAssembly(Assembly.GetAssembly(typeof(INacLagService))).
                //InSameNamespaceAs<INacLagService>().WithService.DefaultInterfaces().LifestyleTransient()

                //Classes.FromAssembly(Assembly.GetAssembly(typeof(SubProductService))).InSameNamespaceAs<ColorService>().WithService.DefaultInterfaces().LifestyleTransient(),
                //Classes.FromAssembly(Assembly.GetAssembly(typeof(IProducerStockNewService))).InSameNamespaceAs<IProducerStockNewService>().WithService.DefaultInterfaces().LifestyleTransient()
                );
        }

        /// <summary>
        /// Creates NHibernate Session Factory.
        /// </summary>
        /// <returns>NHibernate Session Factory</returns>3
        /// 
        private static ISessionFactory CreateNhSessionFactory()
        {
            var connStr = ConfigurationManager.ConnectionStrings["TejeratBankReporting"].ConnectionString;
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(connStr))
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetAssembly(typeof(INSTALLMENTMap))))
                 .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetAssembly(typeof(NACLOGMap))))
                     .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetAssembly(typeof(NACMap))))
                       .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetAssembly(typeof(SUBSCRIPTIONMap))))
                        .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetAssembly(typeof(TRANSACTIONMap))))
                //.Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetAssembly(typeof(ProducerStockNewMap))))
                .BuildSessionFactory();
        }

        void Kernel_ComponentRegistered(string key, Castle.MicroKernel.IHandler handler)
        {
            //Intercept all methods of all repositories.
            if (UnitOfWorkHelper.IsRepositoryClass(handler.ComponentModel.Implementation))
            {
                handler.ComponentModel.Interceptors.Add(new InterceptorReference(typeof(NhUnitOfWorkInterceptor)));
            }

            //Intercept all methods of classes those have at least one method that has UnitOfWork attribute.
            foreach (var method in handler.ComponentModel.Implementation.GetMethods())
            {
                if (UnitOfWorkHelper.HasUnitOfWorkAttribute(method))
                {
                    handler.ComponentModel.Interceptors.Add(new InterceptorReference(typeof(NhUnitOfWorkInterceptor)));
                    return;
                }
            }
        }
    }
}