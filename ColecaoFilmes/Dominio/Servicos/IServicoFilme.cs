using System.Collections.Generic;
using ColecaoFilmes.Dominio.Entidades;

namespace ColecaoFilmes.Dominio.Servicos
{
    public interface IServicoFilme
    {
        void IncluirFilme(Filme filme);
        IList<Filme> RecuperarTodosFilmes();
    }
}