using ProcessoProduto.Data.Repositorio;
using ProcessoProduto.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessoProdutoi.Negocio.Negocio
{
    public class ProdutoNegocio
    {
        private readonly ProdutoRepositorio produtoRepositorio;

        public ProdutoNegocio()
        {
              produtoRepositorio = new ProdutoRepositorio();
        }

        public void AdicionarProduto(Produto produto)
        {
            produtoRepositorio.Adicionar(produto);
        }

        public List<Produto> ListarProduto()
        {
            return produtoRepositorio.ObterTodos();
        }

        public void Atualizar(Produto produto)
        {
            produtoRepositorio.Atualizar(produto);
        }

        public void Deletar(int idProduto)
        {
            produtoRepositorio.Deletar(idProduto);
        }

        public Produto Buscar(int id)
        {
            return produtoRepositorio.Buscar(id, id);
        }
    }
}
