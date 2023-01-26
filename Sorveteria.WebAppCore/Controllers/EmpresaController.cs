using Microsoft.AspNetCore.Mvc;
using Sorveteria.Aplicacao;
using Sorveteria.Dominio;

namespace Sorveteria.WebAppCore.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly EmpresaAplicacao appEmpresa;

        public EmpresaController()
        {
            appEmpresa = EmpresaAplicacaoConstrutor.EmpresaAplicacaoEF();
        }

        public ActionResult Index()
        {
            try
            {
                var listaDeEmpresas = appEmpresa.ListarTodos();
                return View(listaDeEmpresas);
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
        public ActionResult Cadastrar(Empresa empresa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    appEmpresa.Salvar(empresa);
                    return RedirectToAction("Index");
                }

                return View(empresa);
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
                var empresa = appEmpresa.ListarPorId(id);

                if (empresa == null)
                    return null;

                return View(empresa);
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Empresa empresa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    appEmpresa.Salvar(empresa);
                    return RedirectToAction("Index");
                }

                return View(empresa);
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
                var empresa = appEmpresa.ListarPorId(id);

                if (empresa == null)
                    return null;

                return View(empresa);
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
                var empresa = appEmpresa.ListarPorId(id);

                if (empresa == null)
                    return null;

                return View(empresa);
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
                var empresa = appEmpresa.ListarPorId(id);
                appEmpresa.Excluir(empresa);

                return RedirectToAction("Index");
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}
