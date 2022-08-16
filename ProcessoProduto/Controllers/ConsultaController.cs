using Microsoft.AspNetCore.Mvc;
using ProcessoProduto.Dominio.Dominio;
using ProcessoProduto.Models;
using ProcessoProdutoi.Negocio.Negocio;
using System.Collections.Generic;

namespace ProcessoProduto.Controllers
{
    public class ConsultaController : Controller
    {
        private ProdutoNegocio produtoNegocio;

        public ConsultaController()
        {
            produtoNegocio = new ProdutoNegocio();
        }

        public IActionResult Consultar()
        {
            return View();
        }

        public IEnumerable<Produto> ListarProduto()
        {
            List<Produto> listaProduto = new List<Produto>();

            foreach(var produto in listaProduto)
            {
                listaProduto.Add(produto);
            }

            return listaProduto;
        }

        public IActionResult Deletar(int idprodutoVM)
        {

            produtoNegocio.Deletar(idprodutoVM);
            return View("Cadastrar");
        }

        public IActionResult AtulaizarDados(ProdutoView produtoVM)
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
            return View("Cadastrar");
        }
    }
}
