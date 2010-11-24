using ColecaoFilmes.Dominio.Entidades;
using FluentNHibernate.Mapping;

namespace ColecaoFilmes.Infraestrutura.AcessoDados.Mapeamentos
{
    public sealed class ReleasesMap : ClassMap<Release>
    {
        public ReleasesMap()
        {
            Id(x => x.Id).GeneratedBy.Native();
            Map(x => x.Nome);
            Map(x => x.CaminhoArquivoFisico);
            References(x => x.Filme);
        }
    }
}