using System;
using ColecaoFilmes.Dominio.Entidades;
using ColecaoFilmes.Dominio.Repositorios;

namespace ColecaoFilmes.Dominio.Servicos
{
    public class ServicoFilme : IServicoFilme
    {
        private IFilmesRepositorio _repositorio;
        public ServicoFilme(IFilmesRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public void IncluirFilme(Filme filme)
        {
            _repositorio.Incluir(filme);
        }
    }
}