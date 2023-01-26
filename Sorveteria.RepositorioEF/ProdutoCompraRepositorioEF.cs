using Sorveteria.Dominio;
using Sorveteria.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorveteria.RepositorioEF
{
    public class ProdutoCompraRepositorioEF : IRepositorio<ProdutoCompra>
    {
        private readonly Contexto contexto;

        public ProdutoCompraRepositorioEF()
        {
            contexto = new Contexto();
        }

        public void Salvar(ProdutoCompra entidade)
        {
            if (entidade.IdProdutoCompra > 0)
            {
                var compraAlterar = contexto.ProdutoCompra.First(x => x.IdProdutoCompra == entidade.IdProdutoCompra);
                compraAlterar.Produtos = entidade.Produtos;
                compraAlterar.IdEmpresa = entidade.IdEmpresa;
                compraAlterar.IdUsuario = entidade.IdUsuario;
                compraAlterar.Quantidade = entidade.Quantidade;
                compraAlterar.Valor = entidade.Valor;
                compraAlterar.DataHora = entidade.DataHora;
            }
            else
            {
                contexto.ProdutoCompra.Add(entidade);
            }
            contexto.SaveChanges();
        }

        public void Excluir(ProdutoCompra entidade)
        {
            var compraExcluir = contexto.ProdutoCompra.First(x => x.IdProdutoCompra == entidade.IdProdutoCompra);
            contexto.Set<ProdutoCompra>().Remove(compraExcluir);
            contexto.SaveChanges();
        }

        public IEnumerable<ProdutoCompra> ListarTodos()
        {
            return contexto.ProdutoCompra;
        }

        public ProdutoCompra ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            return contexto.ProdutoCompra.First(x => x.IdProdutoCompra == idInt);
        }
    }
}
