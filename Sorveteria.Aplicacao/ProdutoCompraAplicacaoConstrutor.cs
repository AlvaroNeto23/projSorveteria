using Sorveteria.RepositorioEF;

namespace Sorveteria.Aplicacao
{
    public class ProdutoCompraAplicacaoConstrutor
    {
        public static ProdutoCompraAplicacao ProdutoCompraAplicacaoEF()
        {
            return new ProdutoCompraAplicacao(new ProdutoCompraRepositorioEF());
        }
    }
}
