using Microsoft.AspNetCore.Mvc;
using Sorveteria.Aplicacao;
using Sorveteria.Dominio;

namespace Sorveteria.WebAppCore.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoAplicacao appProduto;

        public ProdutoController()
        {
            appProduto = ProdutoAplicacaoConstrutor.ProdutoAplicacaoEF();
        }

        public ActionResult Index()
        {
            try
            {
                var listaDeProdutos = appProduto.ListarTodos();
                return View(listaDeProdutos);
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
        public ActionResult Cadastrar(Produto produto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    appProduto.Salvar(produto);
                    return RedirectToAction("Index");
                }

                return View(produto);
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
                var produto = appProduto.ListarPorId(id);

                if (produto == null)
                    return null;

                return View(produto);
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Produto produto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    appProduto.Salvar(produto);
                    return RedirectToAction("Index");
                }

                return View(produto);
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
                var produto = appProduto.ListarPorId(id);

                if (produto == null)
                    return null;

                return View(produto);
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
                var produto = appProduto.ListarPorId(id);

                if (produto == null)
                    return null;

                return View(produto);
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
                var produto = appProduto.ListarPorId(id);
                appProduto.Excluir(produto);

                return RedirectToAction("Index");
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}
