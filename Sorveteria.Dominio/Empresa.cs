using System.ComponentModel.DataAnnotations;

namespace Sorveteria.Dominio
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }
        [Required(ErrorMessage = "Preencha o campo Razão Social")]
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Preencha o campo CNPJ")]
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }

        //public Empresa()
        //{

        //}
    }
}
