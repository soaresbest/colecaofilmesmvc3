using System.Collections.Generic;

namespace ColecaoFilmes.Dominio.Repositorios
{
    public interface IRepositorio
    {
        void Incluir(object entidade);
        void Alterar(object entidade);
        T Pesquisar<T>(int id);
        void Excluir<T>(T entidade);
        void Excluir(int id);
        IList<T> PesquisarTudo<T>();
    }
}