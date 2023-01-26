using Microsoft.AspNetCore.Mvc;
using Sorveteria.Aplicacao;
using Sorveteria.Dominio;

namespace Sorveteria.WebAppCore.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioAplicacao appUsuario;

        public UsuarioController()
        {
            appUsuario = UsuarioAplicacaoConstrutor.UsuarioAplicacaoEF();
        }

        public ActionResult Index()
        {
            try
            {
                var listaDeUsuarios = appUsuario.ListarTodos();
                return View(listaDeUsuarios);
            }
            catch (System.Exception)
            {
                return null;
            }

        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(Usuario usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    appUsuario.Salvar(usuario);
                    return RedirectToAction("Index");
                }

                return View(usuario);
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public ActionResult Editar(string id)
        {
            try
            {
                var usuario = appUsuario.ListarPorId(id);

                if (usuario == null)
                    return null;

                return View(usuario);
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Usuario usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    appUsuario.Salvar(usuario);
                    return RedirectToAction("Index");
                }

                return View(usuario);
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public ActionResult Detalhes(string id)
        {
            try
            {
                var usuario = appUsuario.ListarPorId(id);

                if (usuario == null)
                    return null;

                return View(usuario);
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public ActionResult Excluir(string id)
        {
            try
            {
                var usuario = appUsuario.ListarPorId(id);

                if (usuario == null)
                    return null;

                return View(usuario);
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public ActionResult ExcluirConfirmado(string id)
        {
            try
            {
                var usuario = appUsuario.ListarPorId(id);
                appUsuario.Excluir(usuario);

                return RedirectToAction("Index");
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}
