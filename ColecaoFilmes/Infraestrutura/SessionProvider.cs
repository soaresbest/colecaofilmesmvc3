using ColecaoFilmes.Infraestrutura.AcessoDados;
using NHibernate;

namespace ColecaoFilmes.Infraestrutura
{
    public class SessionProvider
    {
        ISessionFactory _sessionFactory;
        ISession _session;

        public SessionProvider(SessionFactoryProvider sessionFactoryProvider)
        {
            _sessionFactory = sessionFactoryProvider.GetSessionFactory();
        }

        public ISession GetCurrentSession()
        {
            return _session ?? (_session = _sessionFactory.OpenSession());
        }

        public void Dispose()
        {
            if (_session != null)
            {
                _session.Dispose();
            }
        }
    }
}