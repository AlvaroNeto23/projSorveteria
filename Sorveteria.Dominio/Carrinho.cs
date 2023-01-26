using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sorveteria.Dominio
{
    public class Carrinho
    {
        public int IdCarrinho { get; set; }

        public int IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        public Empresa Empresa { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descrição")]
        public string Descricao { get; set; }
    }
}
