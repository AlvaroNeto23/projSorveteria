using Sorveteria.Dominio.Contrato;
using Sorveteria.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorveteria.RepositorioEF
{
    public class UsuarioRepositorioEF : IRepositorio<Usuario>
    {
        private readonly Contexto contexto;

        public UsuarioRepositorioEF()
        {
            contexto = new Contexto();
        }

        public void Salvar(Usuario entidade)
        {
            if (entidade.IdUsuario > 0)
            {
                var usuarioAlterar = contexto.Usuario.First(x => x.IdUsuario == entidade.IdUsuario);
                usuarioAlterar.IdEmpresa = entidade.IdEmpresa;
                usuarioAlterar.Nome = entidade.Nome;
                usuarioAlterar.RG = entidade.RG;
                usuarioAlterar.Endereco = entidade.Endereco;
                usuarioAlterar.Telefone = entidade.Telefone;
            }
            else
            {
                contexto.Usuario.Add(entidade);
            }
            contexto.SaveChanges();
        }

        public void Excluir(Usuario entidade)
        {
            var usuarioExcluir = contexto.Usuario.First(x => x.IdUsuario == entidade.IdUsuario);
            contexto.Set<Usuario>().Remove(usuarioExcluir);
            contexto.SaveChanges();
        }

        public IEnumerable<Usuario> ListarTodos()
        {
            return contexto.Usuario;
        }

        public Usuario ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            return contexto.Usuario.First(x => x.IdUsuario == idInt);
        }
    }
}
