using Sorveteria.Dominio;
using Sorveteria.Dominio.Contrato;
using System.Collections.Generic;

namespace Sorveteria.Aplicacao
{
    public class ProdutoVendaAplicacao
    {
        private readonly IRepositorio<ProdutoVenda> repositorio;

        public ProdutoVendaAplicacao(IRepositorio<ProdutoVenda> repo)
        {
            repositorio = repo;
        }

        public void Salvar(ProdutoVenda venda)
        {
            repositorio.Salvar(venda);
        }

        public void Excluir(ProdutoVenda venda)
        {
            repositorio.Excluir(venda);
        }

        public IEnumerable<ProdutoVenda> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public ProdutoVenda ListarPorId(string id)
        {
            return repositorio.ListarPorId(id);
        }
    }
}
