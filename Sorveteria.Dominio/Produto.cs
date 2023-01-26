using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sorveteria.Dominio
{
    public class Produto
    {
        public int IdProduto { get; set; }
        [Required(ErrorMessage = "Preencha o campo Código")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "Preencha o campo Descrição")]
        public string Descricao { get; set; }

        public string Preco { get; set; }
        public bool Status { get; set; }
        public string Lote { get; set; }
        public int EstoqueMinimo { get; set; }
        public DateTime DtValidade { get; set; }

        public virtual IEnumerable<ProdutoCompra> ProdutoCompras { get; set; }
        public virtual IEnumerable<ProdutoVenda> ProdutoVendas { get; set; }
    }
}
