using ColecaoFilmes.Dominio.Entidades;
using NUnit.Framework;

namespace Dominio.Testes
{
    [TestFixture]
    public class FilmeTeste
    {
        [Test]
        public void IncluirRelease_Teste()
        {
            Filme filme = new Filme();

            Release release = new Release();

            Assert.IsNull(filme.Releases);

            filme.IncluirRelease(release);

            Assert.IsNotNull(filme.Releases);
            Assert.IsTrue(filme.Releases.Count > 0);
        }
    }
}
