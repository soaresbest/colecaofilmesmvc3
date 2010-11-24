using System;
using System.Collections.Generic;
using ColecaoFilmes.Dominio.Repositorios;

namespace ColecaoFilmes.Infraestrutura.DataAccess.DAOs
{
    public class DAOGenerico : IRepositorio
    {
        public void Incluir(object entidade)
        {
            throw new NotImplementedException();
        }

        public void Alterar(object entidade)
        {
            throw new NotImplementedException();
        }

        public IList<T> PesquisarLista<T>(T entidade)
        {
            throw new NotImplementedException();
        }

        public T Pesquisar<T>(int id)
        {
            throw new NotImplementedException();
        }

        public void Excluir<T>(T entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IList<T> PesquisarTudo<T>()
        {
            throw new NotImplementedException();
        }
    }
}