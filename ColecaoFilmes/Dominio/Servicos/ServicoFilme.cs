using System;
using System.Collections.Generic;
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
            _repositorio.Salvar(filme);
        }

        public void AlterarFilme(Filme filme)
        {
            _repositorio.Alterar(filme);
        }

        public void ExcluirFilme(Filme filme)
        {
            _repositorio.Excluir(filme);
        }

        public IList<Filme> RecuperarTodosFilmes()
        {
            return _repositorio.PesquisarTudo<Filme>();
        }

        public Filme RecuperarFilme(int id)
        {
            return _repositorio.RecuperarFilme(id);
        }
    }
}