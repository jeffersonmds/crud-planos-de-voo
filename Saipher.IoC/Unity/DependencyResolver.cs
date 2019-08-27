using prmToolkit.NotificationPattern;
using Saipher.Domain.Interfaces.Repositories;
using Saipher.Domain.Interfaces.Repositories.Base;
using Saipher.Domain.Interfaces.Services;
using Saipher.Domain.Services;
using Saipher.Infra.Persistence;
using Saipher.Infra.Persistence.Repositories;
using Saipher.Infra.Persistence.Repositories.Base;
using Saipher.Infra.Transactions;
using System.Data.Entity;
using Unity;
using Unity.Lifetime;

namespace Saipher.IoC.Unity
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {

            container.RegisterType<DbContext, SaipherContext>(new HierarchicalLifetimeManager());
            //UnitOfWork
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<INotifiable, Notifiable>(new HierarchicalLifetimeManager());

            //Serviço de Domain
            //container.RegisterType(typeof(IServiceBase<,>), typeof(ServiceBase<,>));

            container.RegisterType<IServiceAeronave, ServiceAeronave>(new HierarchicalLifetimeManager());
            container.RegisterType<IServiceAeroporto, ServiceAeroporto>(new HierarchicalLifetimeManager());
            container.RegisterType<IServicePlanoDeVoo, ServicePlanoDeVoo>(new HierarchicalLifetimeManager());
            container.RegisterType<IServiceVoo, ServiceVoo>(new HierarchicalLifetimeManager());



            //Repository
            container.RegisterType(typeof(IRepositoryBase<,>), typeof(RepositoryBase<,>));

            container.RegisterType<IRepositoryAeronave, RepositoryAeronave>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositoryAeroporto, RepositoryAeroporto>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositoryPlanoDeVoo, RepositoryPlanoDeVoo>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositoryVoo, RepositoryVoo>(new HierarchicalLifetimeManager());



        }
    }
}
