using Sorveteria.Dominio;
using Sorveteria.Dominio.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorveteria.RepositorioEF
{
    public class EmpresaRepositorioEF : IRepositorio<Empresa>
    {
        private readonly Contexto contexto;

        public EmpresaRepositorioEF()
        {
            contexto = new Contexto();
        }

        public void Salvar(Empresa entidade)
        {
            if (entidade.IdEmpresa > 0)
            {
                var empresaAlterar = contexto.Empresa.First(x => x.IdEmpresa == entidade.IdEmpresa);
                empresaAlterar.RazaoSocial = entidade.RazaoSocial;
                empresaAlterar.NomeFantasia = entidade.NomeFantasia;
                empresaAlterar.CNPJ = entidade.CNPJ;
                empresaAlterar.Endereco = entidade.Endereco;
                empresaAlterar.CEP = entidade.CEP;
                empresaAlterar.Telefone = entidade.Telefone;
            }
            else
            {
                contexto.Empresa.Add(entidade);
            }
            contexto.SaveChanges();
        }

        public void Excluir(Empresa entidade)
        {
            var empresaExcluir = contexto.Empresa.First(x => x.IdEmpresa == entidade.IdEmpresa);
            contexto.Set<Empresa>().Remove(empresaExcluir);
            contexto.SaveChanges();
        }

        public IEnumerable<Empresa> ListarTodos()
        {
            return contexto.Empresa;            
        }

        public Empresa ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            return contexto.Empresa.First(x => x.IdEmpresa == idInt);
        }
    }
}
