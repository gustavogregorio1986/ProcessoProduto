using Microsoft.AspNetCore.Mvc;
using ProcessoProduto.Dominio.Dominio;
using ProcessoProduto.Models;
using ProcessoProdutoi.Negocio.Negocio;

namespace ProcessoProduto.Controllers
{
    public class EdiitarController1 : Controller
    {
        private ProdutoNegocio produtoNegocio;

        public EdiitarController1()
        {
           produtoNegocio = new ProdutoNegocio();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult AtualizarDados(int idproduto)
        {
            
            produtoNegocio.Buscar(idproduto)
            return View("Consultar");
        }

        public IActionResult EditarDados(ProdutoView produtoVM)
        {
            produtoVM = new ProdutoView();
            Produto produto = new Produto();
            produtoVM.UserName = produto.UserName;
            produtoVM.FullName = produto.FullName;
            produtoVM.Date = produto.Date;
            produtoVM.Country = produto.Country;
            produtoVM.Active = produto.Active;
            produtoVM.Id = produto.Id;
            produtoNegocio.Atualizar(produto);
            return View("Consultar");
        }
    }
}
