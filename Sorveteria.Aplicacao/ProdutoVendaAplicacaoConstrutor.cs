using Sorveteria.RepositorioEF;

namespace Sorveteria.Aplicacao
{
    public class ProdutoVendaAplicacaoConstrutor
    {
        public static ProdutoVendaAplicacao ProdutoVendaAplicacaoEF()
        {
            return new ProdutoVendaAplicacao(new ProdutoVendaRepositorioEF());
        }
    }
}
