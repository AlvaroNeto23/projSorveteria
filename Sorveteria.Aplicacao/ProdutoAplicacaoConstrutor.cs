using Sorveteria.RepositorioEF;

namespace Sorveteria.Aplicacao
{
    public class ProdutoAplicacaoConstrutor
    {
        public static ProdutoAplicacao ProdutoAplicacaoEF()
        {
            return new ProdutoAplicacao(new ProdutoRepositorioEF());
        }
    }
}
