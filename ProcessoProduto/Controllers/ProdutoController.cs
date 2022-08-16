using Microsoft.AspNetCore.Mvc;
using ProcessoProduto.Dominio.Dominio;
using ProcessoProduto.Models;
using ProcessoProdutoi.Negocio.Negocio;

namespace ProcessoProduto.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoNegocio produtoNegocio;

        public ProdutoController()
        {
            produtoNegocio = new ProdutoNegocio();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult CadatsrarDados(ProdutoView produtoVM)
        {
            produtoVM = new ProdutoView();
            Produto produto = new Produto();
            produtoVM.Id = produto.Id;
            produtoVM.UserName = produto.UserName;
            produtoVM.FullName = produto.FullName;
            produtoVM.Date = produto.Date;
            produtoVM.Country = produto.Country;
            produtoVM.Active = produto.Active;
            produtoNegocio.AdicionarProduto(produto);
            return View("Cadastrar");
        }

       
    }
}
