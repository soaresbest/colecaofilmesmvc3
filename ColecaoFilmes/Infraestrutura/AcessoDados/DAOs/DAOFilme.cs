using System;
using System.Collections.Generic;
using ColecaoFilmes.Dominio.Entidades;
using ColecaoFilmes.Dominio.Repositorios;
using ColecaoFilmes.Infraestrutura.AcessoDados;
using NHibernate;

namespace ColecaoFilmes.Infraestrutura.DataAccess.DAOs
{
    public class DAOFilme : DAOGenerico,IFilmesRepositorio
    {
        private SessionFactoryProvider _nhHelper;

        public DAOFilme(SessionFactoryProvider nhHelper)
        {
            _nhHelper = nhHelper;
        }
        public Filme PesquisarPorNome(Filme filme)
        {
            throw new NotImplementedException();
        }
        
    }
}