using Microsoft.EntityFrameworkCore;
using ProcessoProduto.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessoProduto.Data.Contexto
{
    public class ProcessoProdutoContexto : DbContext
    {
        public ProcessoProdutoContexto()
        {

        }

        public ProcessoProdutoContexto(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
