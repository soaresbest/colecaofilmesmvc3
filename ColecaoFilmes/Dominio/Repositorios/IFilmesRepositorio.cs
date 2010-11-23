using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColecaoFilmes.Dominio.Entidades;
using ColecaoFilmes.Dominio.Repositorios;

namespace ColecaoFilmes.Dominio.Repositorios
{
    public interface IFilmesRepositorio : IRepositorio
    {
        Filme PesquisarPorNome(Filme filme);
    }
}
