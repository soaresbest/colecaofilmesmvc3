using System;
using System.Collections.Generic;
using ColecaoFilmes.Dominio.Repositorios;
using NHibernate;

namespace ColecaoFilmes.Infraestrutura.AcessoDados.DAOs
{
    public class DAOGenerico : IRepositorio
    {
        private SessionProvider _sessionProvider;

        protected ISession Session
        {
            get
            {
                return _sessionProvider.GetCurrentSession();
            }
        }


        public DAOGenerico(SessionProvider sessionProvider)
        {
            _sessionProvider = sessionProvider;
        }
        
        public void Salvar(object entidade)
        {
            Session.Save(entidade);
        }

        public void Alterar(object entidade)
        {
            Session.Update(entidade);
            Session.Flush();
        }

        public T Pesquisar<T>(int id)
        {
            return Session.Load<T>(id);
        }

        public void Excluir(object entidade)
        {
            Session.Delete(entidade);
            Session.Flush();
        }

        public void Excluir<T>(int id)
        {
            var entidade = Pesquisar<T>(id);
            Excluir(entidade);
        }

        public IList<T> PesquisarTudo<T>()
        {
            var criteria = Session.CreateCriteria(typeof(T));
            return criteria.List<T>();

        }
    }
}