using ProcessoProduto.Data.Repositorio.Inerface;
using ProcessoProduto.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessoProduto.Data.Repositorio
{
    public class ProdutoRepositorio : GenericRepositorio<Produto>, IPordutoRepositorio
    {
        public IEnumerable<Produto> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}
