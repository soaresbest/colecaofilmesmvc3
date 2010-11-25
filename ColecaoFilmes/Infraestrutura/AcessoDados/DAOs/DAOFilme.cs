using System;
using System.Linq;
using ColecaoFilmes.Dominio.Entidades;
using ColecaoFilmes.Dominio.Repositorios;

namespace ColecaoFilmes.Infraestrutura.AcessoDados.DAOs
{
    public class DAOFilme : DAOGenerico,IFilmesRepositorio
    {
        public DAOFilme(SessionProvider sessionProvider) : base(sessionProvider)
        {

        }

        public Filme PesquisarPorNome(Filme filme)
        {
            var query = Session.CreateQuery("select Filme f where f.NomeOriginal = :nome");
            return query.List<Filme>().First();
        }

        public Filme RecuperarFilme(int id)
        {
            var filme = Session.Load<Filme>(id);
            return filme;
        }
    }
}