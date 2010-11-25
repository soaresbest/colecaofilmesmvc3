using System.Collections.Generic;

namespace ColecaoFilmes.Dominio.Entidades
{
    public class Filme
    {
        public virtual string NomeOriginal { get; set; }

        public virtual string ImdbId { get; set; }

        public virtual IList<Release> Releases { get; set; }

        #region IEntidade Members

        public virtual int Id { get; set; }

        #endregion

        public virtual void IncluirRelease(Release release)
        {
            if (Releases == null)
                Releases = new List<Release>();

            release.Filme = this;
            Releases.Add(release);
        }
    }
}