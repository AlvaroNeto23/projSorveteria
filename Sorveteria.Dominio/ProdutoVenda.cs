using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sorveteria.Dominio
{
    public class ProdutoVenda
    {
        public int IdProdutoVenda { get; set; }

        public List<Produto> Produtos { get; set; }

        public int IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        public Empresa Empresa { get; set; }

        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public DateTime DataHora { get; set; }
    }
}
