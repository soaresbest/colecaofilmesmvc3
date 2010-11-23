using ColecaoFilmes.Dominio.Entidades;

namespace ColecaoFilmes.Dominio.Servicos
{
    public interface IServicoFilme
    {
        void IncluirFilme(Filme filme);
    }
}