using System.Web.Mvc;
using ColecaoFilmes.Dominio.Repositorios;
using ColecaoFilmes.Dominio.Servicos;
using ColecaoFilmes.Infraestrutura;
using ColecaoFilmes.Infraestrutura.AcessoDados;
using ColecaoFilmes.Infraestrutura.AcessoDados.DAOs;
using Ninject;
using Ninject.Mvc3;

[assembly: WebActivator.PreApplicationStartMethod(typeof(ColecaoFilmesMVC3.AppStart_NinjectMVC3), "Start")]

namespace ColecaoFilmesMVC3 {
    public static class AppStart_NinjectMVC3 {
        public static void RegisterServices(IKernel kernel) {
            //kernel.Bind<IThingRepository>().To<SqlThingRepository>();
            kernel.Bind<SessionFactoryProvider>().ToSelf().InSingletonScope();
            kernel.Bind<SessionProvider>().ToSelf().InRequestScope();
            kernel.Bind<IFilmesRepositorio>().To<DAOFilme>().InRequestScope();
            kernel.Bind<IServicoFilme>().To<ServicoFilme>();
        }

        public static void Start() {
            // Create Ninject DI Kernel 
            IKernel kernel = new StandardKernel();

            // Register services with our Ninject DI Container
            RegisterServices(kernel);

            // Tell ASP.NET MVC 3 to use our Ninject DI Container 
            DependencyResolver.SetResolver(new NinjectServiceLocator(kernel));
        }
    }
}
