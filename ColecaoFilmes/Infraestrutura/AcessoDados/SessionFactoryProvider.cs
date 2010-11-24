using System;
using ColecaoFilmes.Data.RepositorioSqlNhibernate.Conventions;
using ColecaoFilmes.Infraestrutura.AcessoDados.Mapeamentos;
using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions;
using NHibernate;

namespace ColecaoFilmes.Infraestrutura.AcessoDados
{
    public class SessionFactoryProvider : IDisposable
    {
        private  ISessionFactory _sessionFactory;

        public  ISessionFactory GetSessionFactory()
        {
            FluentConfiguration cfg = Fluently.Configure()
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<FilmesMap>()
                                   .Conventions.Setup(GetConventions()))
                .Database(MsSqlConfiguration.MsSql2008.ShowSql()
                              .ConnectionString(c => c.FromConnectionStringWithKey("ConnectionString"))
                );

            _sessionFactory = cfg.BuildSessionFactory();
            //BuildSchema(cfg);

            return _sessionFactory;
        }

        private void BuildSchema(FluentConfiguration configuration)
        {
            var sessionSource = new SessionSource(configuration);
            ISession session = sessionSource.CreateSession();
            sessionSource.BuildSchema(session);
        }

        private Action<IConventionFinder> GetConventions()
        {
            return c =>
            {
                c.Add<CascadeConvention>();
                c.Add<EnumConvention>();
            };
        }

        public void Dispose()
        {
            if(_sessionFactory != null)
                _sessionFactory.Dispose();
        }
    }
}
