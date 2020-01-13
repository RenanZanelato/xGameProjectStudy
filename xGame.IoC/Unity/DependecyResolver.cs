using prmToolkit.NotificationPattern;
using System.Data.Entity;
using Unity;
using Unity.Lifetime;
using xGame.Domain.Interfaces.Repositories;
using xGame.Domain.Interfaces.Repositories.Base;
using xGame.Domain.Interfaces.Services;
using xGame.Domain.Services;
using xGame.Infra.Persistence;
using xGame.Infra.Persistence.Repositories;
using xGame.Infra.Persistence.Repositories.Base;
using xGame.Infra.Transactions;

namespace xGame.IoC.Unity
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {

            container.RegisterType<DbContext, XGameContext>(new HierarchicalLifetimeManager());
            //UnitOfWork
            container.RegisterType<IUnityOfWork, UnityOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<INotifiable, Notifiable>(new HierarchicalLifetimeManager());

            //Serviço de Domain
            //container.RegisterType(typeof(IServiceBase<,>), typeof(ServiceBase<,>));

            container.RegisterType<IServicePlayer, ServicePlayer>(new HierarchicalLifetimeManager());
            //container.RegisterType<IServiceGame, ServiceGame>(new HierarchicalLifetimeManager());



            //Repository
            container.RegisterType(typeof(IRepositoryBase<,>), typeof(RepositoryBase<,>));

            container.RegisterType<IRepositoryPlayer, RepositoryPlayer>(new HierarchicalLifetimeManager());
            // container.RegisterType<IRepositoryGame, RepositoryGame>(new HierarchicalLifetimeManager());



        }
    }
}
