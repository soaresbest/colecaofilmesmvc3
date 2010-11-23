using System;
using System.Collections.Generic;
using ColecaoFilmes.Dominio.Entidades;
using ColecaoFilmes.Dominio.Repositorios;

namespace ColecaoFilmes.Infraestrutura.DataAccess.DAOs
{
    public class DAOFilme : DAOGenerico,IFilmesRepositorio
    {
        public Filme PesquisarPorNome(Filme filme)
        {
            throw new NotImplementedException();
        }
    }
}