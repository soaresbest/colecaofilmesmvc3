namespace ColecaoFilmes.Dominio.Entidades
{
    public class Release : IEntidade
    {
        public virtual string Nome { get; set; }
        public virtual Filme Filme { get; set; }
        public virtual string CaminhoArquivoFisico { get; set; }

        #region IEntidade Members

        public virtual int Id { get; private set; }

        #endregion
    }
}