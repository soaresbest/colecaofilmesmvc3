using ColecaoFilmes.Dominio.Entidades;
using FluentNHibernate.Mapping;

namespace ColecaoFilmes.Infraestrutura.AcessoDados.Mapeamentos
{
    public sealed class FilmesMap : ClassMap<Filme>
    {
        public FilmesMap()
        {
            Id(x => x.Id).GeneratedBy.Native();
            Map(x => x.NomeOriginal);
            Map(x => x.ImdbId);
            HasMany(x => x.Releases);
        }
    }
}