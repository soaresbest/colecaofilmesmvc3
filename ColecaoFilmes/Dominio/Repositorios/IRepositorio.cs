using System.Collections.Generic;

namespace ColecaoFilmes.Dominio.Repositorios
{
    public interface IRepositorio
    {
        void Salvar(object entidade);
        void Alterar(object entidade);
        T Pesquisar<T>(int id);
        void Excluir(object entidade);
        void Excluir<T>(int id);
        IList<T> PesquisarTudo<T>();
    }
}