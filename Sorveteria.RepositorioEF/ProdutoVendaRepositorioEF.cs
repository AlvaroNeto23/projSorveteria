using Sorveteria.Dominio;
using Sorveteria.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorveteria.RepositorioEF
{
    public class ProdutoVendaRepositorioEF : IRepositorio<ProdutoVenda>
    {
        private readonly Contexto contexto;

        public ProdutoVendaRepositorioEF()
        {
            contexto = new Contexto();
        }

        public void Salvar(ProdutoVenda entidade)
        {
            if (entidade.IdProdutoVenda > 0)
            {
                var vendaAlterar = contexto.ProdutoVenda.First(x => x.IdProdutoVenda == entidade.IdProdutoVenda);
                vendaAlterar.Produtos = entidade.Produtos;
                vendaAlterar.IdEmpresa = entidade.IdEmpresa;
                vendaAlterar.IdUsuario = entidade.IdUsuario;
                vendaAlterar.Quantidade = entidade.Quantidade;
                vendaAlterar.Valor = entidade.Valor;
                vendaAlterar.DataHora = entidade.DataHora;
            }
            else
            {
                contexto.ProdutoVenda.Add(entidade);
            }
            contexto.SaveChanges();
        }

        public void Excluir(ProdutoVenda entidade)
        {
            var vendaExcluir = contexto.ProdutoVenda.First(x => x.IdProdutoVenda == entidade.IdProdutoVenda);
            contexto.Set<ProdutoVenda>().Remove(vendaExcluir);
            contexto.SaveChanges();
        }

        public IEnumerable<ProdutoVenda> ListarTodos()
        {
            return contexto.ProdutoVenda;
        }

        public ProdutoVenda ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            return contexto.ProdutoVenda.First(x => x.IdProdutoVenda == idInt);
        }
    }
}
