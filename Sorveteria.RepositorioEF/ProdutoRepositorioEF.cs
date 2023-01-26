using Sorveteria.Dominio;
using Sorveteria.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorveteria.RepositorioEF
{
    public class ProdutoRepositorioEF : IRepositorio<Produto>
    {
        private readonly Contexto contexto;

        public ProdutoRepositorioEF()
        {
            contexto = new Contexto();
        }

        public void Salvar(Produto entidade)
        {
            if (entidade.IdProduto > 0)
            {
                var produtoAlterar = contexto.Produto.First(x => x.IdProduto == entidade.IdProduto);
                produtoAlterar.Codigo = entidade.Codigo;
                produtoAlterar.Descricao = entidade.Descricao;
                produtoAlterar.Preco = entidade.Preco;
                produtoAlterar.Status = entidade.Status;
                produtoAlterar.Lote = entidade.Lote;
                produtoAlterar.EstoqueMinimo = entidade.EstoqueMinimo;
                produtoAlterar.DtValidade = entidade.DtValidade;
            }
            else
            {
                contexto.Produto.Add(entidade);
            }
            contexto.SaveChanges();
        }

        public void Excluir(Produto entidade)
        {
            var produtoExcluir = contexto.Produto.First(x => x.IdProduto == entidade.IdProduto);
            contexto.Set<Produto>().Remove(produtoExcluir);
            contexto.SaveChanges();
        }

        public IEnumerable<Produto> ListarTodos()
        {
            return contexto.Produto;
        }

        public Produto ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            return contexto.Produto.First(x => x.IdProduto == idInt);
        }
    }
}
