using Sorveteria.Dominio;
using Sorveteria.Dominio.Contrato;
using System.Collections.Generic;

namespace Sorveteria.Aplicacao
{
    public class EmpresaAplicacao
    {
        private readonly IRepositorio<Empresa> repositorio;

        public EmpresaAplicacao(IRepositorio<Empresa> repo)
        {
            repositorio = repo;
        }

        public void Salvar(Empresa empresa)
        {
            repositorio.Salvar(empresa);
        }

        public void Excluir(Empresa empresa)
        {
            repositorio.Excluir(empresa);
        }

        public IEnumerable<Empresa> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public Empresa ListarPorId(string id)
        {
            return repositorio.ListarPorId(id);
        }
    }
}
