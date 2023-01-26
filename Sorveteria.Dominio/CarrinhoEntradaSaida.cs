using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Sorveteria.Dominio
{
    public class CarrinhoEntradaSaida
    {
        public int IdCarrinhoEntradaSaida { get; set; }
        [Required(ErrorMessage = "Selecione o Carrinho")]

        public int IdCarrinho { get; set; }
        [ForeignKey("IdCarrinho")]
        public Carrinho Carrinho { get; set; }

        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; } 
        
        public DateTime DataHora_Entrada { get; set; }
        public DateTime DataHora_Saida { get; set; }
        public string Observacao { get; set; }
    }
}
