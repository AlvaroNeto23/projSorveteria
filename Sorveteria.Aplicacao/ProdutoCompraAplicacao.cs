using Sorveteria.Dominio;
using Sorveteria.Dominio.Contrato;
using System.Collections.Generic;

namespace Sorveteria.Aplicacao
{
    public class ProdutoCompraAplicacao
    {
        private readonly IRepositorio<ProdutoCompra> repositorio;

        public ProdutoCompraAplicacao(IRepositorio<ProdutoCompra> repo)
        {
            repositorio = repo;
        }

        public void Salvar(ProdutoCompra compra)
        {
            repositorio.Salvar(compra);
        }

        public void Excluir(ProdutoCompra compra)
        {
            repositorio.Excluir(compra);
        }

        public IEnumerable<ProdutoCompra> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public ProdutoCompra ListarPorId(string id)
        {
            return repositorio.ListarPorId(id);
        }
    }
}
