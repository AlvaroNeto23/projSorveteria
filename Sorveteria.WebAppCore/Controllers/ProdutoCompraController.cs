using Microsoft.AspNetCore.Mvc;
using Sorveteria.Aplicacao;
using Sorveteria.Dominio;

namespace Sorveteria.WebAppCore.Controllers
{
    public class ProdutoCompraController : Controller
    {
        private readonly ProdutoCompraAplicacao appProdutoCompra;

        public ProdutoCompraController()
        {
            appProdutoCompra = ProdutoCompraAplicacaoConstrutor.ProdutoCompraAplicacaoEF();
        }

        public ActionResult Index()
        {
            try
            {
                var listaDeProdutoCompras = appProdutoCompra.ListarTodos();
                return View(listaDeProdutoCompras);
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
        public ActionResult Cadastrar(ProdutoCompra compra)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    appProdutoCompra.Salvar(compra);
                    return RedirectToAction("Index");
                }

                return View(compra);
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
                var compra = appProdutoCompra.ListarPorId(id);

                if (compra == null)
                    return null;

                return View(compra);
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(ProdutoCompra compra)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    appProdutoCompra.Salvar(compra);
                    return RedirectToAction("Index");
                }

                return View(compra);
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
                var compra = appProdutoCompra.ListarPorId(id);

                if (compra == null)
                    return null;

                return View(compra);
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
                var compra = appProdutoCompra.ListarPorId(id);

                if (compra == null)
                    return null;

                return View(compra);
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
                var compra = appProdutoCompra.ListarPorId(id);
                appProdutoCompra.Excluir(compra);

                return RedirectToAction("Index");
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}
