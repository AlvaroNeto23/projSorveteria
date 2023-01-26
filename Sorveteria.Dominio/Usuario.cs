using System.ComponentModel.DataAnnotations.Schema;

namespace Sorveteria.Dominio
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public int IdEmpresa { get; set; }
        [ForeignKey("IdEmpresa")]
        public Empresa Empresa { get; set; }

        public string Nome { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }
}
