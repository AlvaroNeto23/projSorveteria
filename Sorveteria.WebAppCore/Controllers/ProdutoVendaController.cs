using Microsoft.AspNetCore.Mvc;
using Sorveteria.Aplicacao;
using Sorveteria.Dominio;

namespace Sorveteria.WebAppCore.Controllers
{
    public class ProdutoVendaController : Controller
    {
        private readonly ProdutoVendaAplicacao appProdutoVenda;

        public ProdutoVendaController()
        {
            appProdutoVenda = ProdutoVendaAplicacaoConstrutor.ProdutoVendaAplicacaoEF();
        }

        public ActionResult Index()
        {
            try
            {
                var listaDeProdutoVendas = appProdutoVenda.ListarTodos();
                return View(listaDeProdutoVendas);
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
        public ActionResult Cadastrar(ProdutoVenda venda)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    appProdutoVenda.Salvar(venda);
                    return RedirectToAction("Index");
                }

                return View(venda);
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
                var venda = appProdutoVenda.ListarPorId(id);

                if (venda == null)
                    return null;

                return View(venda);
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(ProdutoVenda venda)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    appProdutoVenda.Salvar(venda);
                    return RedirectToAction("Index");
                }

                return View(venda);
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
                var venda = appProdutoVenda.ListarPorId(id);

                if (venda == null)
                    return null;

                return View(venda);
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
                var venda = appProdutoVenda.ListarPorId(id);

                if (venda == null)
                    return null;

                return View(venda);
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
                var venda = appProdutoVenda.ListarPorId(id);
                appProdutoVenda.Excluir(venda);

                return RedirectToAction("Index");
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}
