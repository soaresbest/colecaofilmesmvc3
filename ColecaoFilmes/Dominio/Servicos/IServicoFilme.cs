using System.Collections.Generic;
using ColecaoFilmes.Dominio.Entidades;

namespace ColecaoFilmes.Dominio.Servicos
{
    public interface IServicoFilme
    {
        void IncluirFilme(Filme filme);
        void AlterarFilme(Filme filme);
        void ExcluirFilme(Filme filme);
        IList<Filme> RecuperarTodosFilmes();
        Filme RecuperarFilme(int id);
    }
}